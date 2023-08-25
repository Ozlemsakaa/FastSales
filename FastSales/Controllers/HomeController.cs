using BL.Concrete;
using DAL.DTO;
using DAL.Entity;
using DAL.Model;
using FastSales.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using X.PagedList;

namespace FastSales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        CategoryManager categorymanager = new CategoryManager(new EFCategoryRepository());
        BasketManager basketmanager = new BasketManager(new EFBasketRepository());
        BasketDetailManager basketdetailmanager = new BasketDetailManager(new EFBasketDetailRepository(), new EFProductRepository(), new EFProductSkuRepository(), new EFProductSkuPriceRepository());
        ProductManager productmanager = new ProductManager(new EFProductSkuRepository());
        CustomerManager customermanager = new CustomerManager(new EFCustomerRepository());
        AccountTransactionManager accounttransactionmanager = new AccountTransactionManager(new EFAccountTransactionRepository());
        OrderManager ordermanager = new OrderManager(new EFOrderRepository(), new EFOrderDetailRepository());
        ReturnOrderManager returnordermanager = new ReturnOrderManager(new EFReturnOrderRepository(), new EFReturnOrderDetailRepository());
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page = 1)//index sayfası favori ürünleri listeler
        {
            var data = basketdetailmanager.GetProductSku(null).ToPagedList(page, 10);
            return View(data);
        }
        public IActionResult ReturnOrder()//index sayfası favori ürünleri listeler
        {
            return View();
        }
        public PartialViewResult Menu()//üst menüyü getirir. Hızlı satışa açık olan kategoriler gelir.
        {
            try
            {
                var data = categorymanager.GetList();
                return PartialView(data);
            }
            catch
            {
                return PartialView();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]//sepet detayı yüklenmesi için kullanılır.
        public PartialViewResult MiniCartList()
        {
            try
            {
                var basket = basketmanager.GetBasketList(true);
                int basketid = 0;
                if (basket.Count > 0)
                    basketid = basket.FirstOrDefault().Id;
                var data = basketdetailmanager.GetBasketDetailList(basketid);
                return PartialView(data);
            }
            catch
            {
                return PartialView();
            }

        }

        [HttpGet]//üstmenüden tıklanan kategori yada arama barından gelen kelimeye göre sonuçları partialview olarak döndürür
        public PartialViewResult ProductWithParameter(int? categoryId, string word, int page = 1)
        {
            try
            {
                ViewBag.categoryId = categoryId;
                ViewBag.word = word;
                ModelState.Clear();
                if (string.IsNullOrEmpty(word))
                {

                    return PartialView(basketdetailmanager.GetProductSku(categoryId).ToPagedList(page, 10));
                }
                else
                {
                    return PartialView(basketdetailmanager.GetProductSkuWithSearch(word).ToPagedList(page, 10));
                }
            }
            catch
            {
                return PartialView();
            }


        }
        [HttpGet]//sepet için carilerin yüklenmesinde kullanılır. jsevent.js
        public JsonResult BasketCustomerList()
        {
            try
            {
                var data = customermanager.GetList();
                return Json(new { success = true, data = data });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }
        [HttpPost]//yeni cari oluşturmak için kullanılır. jsevent.js
        public JsonResult AddNewCustomer(Customer customer)
        {
            try
            {
                var result = customermanager.CustomerAdd(customer);
                Basket basketcheck;
                basketcheck = basketmanager.GetBasketList(true).FirstOrDefault();
                if (result != null)
                {
                    if (basketcheck != null)
                    {
                        basketcheck.CustomerId = result.Id;
                        basketmanager.UpdateBasket(basketdetailmanager.GetBasketDetailList(basketcheck.Id), basketcheck);
                        return Json(new { success = true, data = "Müşteri eklendi ve sepette güncellendi." });
                    }
                    else
                    {
                        return Json(new { success = true, data = "Müşteri eklendi fakat aktif sepet bulunamadı.." });
                    }
                }
                else
                {
                    throw new Exception("Müşteri kaydı gerçekleşmedi..");
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }

        [HttpGet]//Park edilen sepetleri gösterir. Modal içinde gösterilir. jsevent.js
        public JsonResult GetParkedBasketList()
        {
            try
            {
                var data = basketmanager.GetBasketList(false);
                foreach (var item in data)
                {
                    item.BasketDetails = basketdetailmanager.GetBasketDetailList(item.Id);
                }
                return Json(new { success = true, data = data });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpGet]//Bugün yapılan satışları gösterir. Modal içinde gösterilir. jsevent.js
        public JsonResult GetDateNowOrder()
        {
            try
            {
                return Json(new { success = true, data = ordermanager.GetOrderList(DateTime.Now, null) });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }

        [HttpPost]//siparişe ürün eklenmesi için kullanılır. sepet yok ise oluşturulur jsevent.js
        public JsonResult AddBasket(BasketDetail basketdetail)
        {
            try
            {
                //servis tarafına alınması gerekiyor
                var basket = basketmanager.GetBasketList(true).FirstOrDefault();
                Basket _basket;
                if (basket == null)
                    _basket = basketmanager.BasketAdd(new Basket());
                else
                    _basket = basket;
                basketdetail.BasketId = _basket.Id;
                basketdetailmanager.BasketDetailAdd(basketdetail);
                basketmanager.UpdateBasket(basketdetailmanager.GetBasketDetailList(basketdetail.BasketId), _basket);
                return Json("Ürün sepete başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpPost]//sepet detayı temizlemek için kullanılır jsevent.js
        public JsonResult DeleteBasketDetail()
        {
            try
            {
                Basket basketcheck;
                basketcheck = basketmanager.GetBasketList(true).FirstOrDefault();
                if (basketcheck != null)
                {
                    var data = basketdetailmanager.GetBasketDetailList(basketcheck.Id);
                    if (data.Count > 0)
                    {
                        basketdetailmanager.DeleteBasketDetail(data);
                        basketmanager.UpdateBasket(basketdetailmanager.GetBasketDetailList(basketcheck.Id), basketcheck);
                        return Json("Sepete başarıyla güncellendi.");
                    }
                    else
                    {
                        Json("hide");
                    }

                }
                return Json("hide");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }
        [HttpPost]//aktif sepete değişimi yapmaktadır. jsevent.js
        public JsonResult ChangeBasket(int basketId)
        {
            try
            {
                var basketdeactive = basketmanager.GetBasket(basketId);
                var basketactive = basketmanager.GetBasketList(true).FirstOrDefault();
                if (basketdeactive != null)
                {
                    basketmanager.ChangeBasket(basketdeactive, basketactive);
                    return Json("Sepete başarıyla değiştirildi.");
                }
                return Json("hide");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }
        [HttpPost]//sepet başlığında güncelleme yapmak için kullanılır. jsevent.js 
        public JsonResult UpdateBasket(Basket basket)
        {
            try
            {
                Basket basketcheck;
                if (basket.Id != 0)
                    basketcheck = basketmanager.GetBasket(basket.Id);
                else
                    basketcheck = basketmanager.GetBasketList(true).FirstOrDefault();
                if (basketcheck != null)
                {
                    basketcheck.CustomerId = basket.CustomerId != 0 ? basket.CustomerId : basketcheck.CustomerId;
                    basketcheck.Status = basket.Status == false ? false : basketcheck.Status;
                    basketcheck.Discount = basket.Discount;
                    basketcheck.DiscountType = basket.DiscountType != 0 ? basket.DiscountType : basketcheck.DiscountType;
                    basketcheck.Notes = basket.Notes != basketcheck.Notes ? basket.Notes : basketcheck.Notes;
                    basketmanager.UpdateBasket(basketdetailmanager.GetBasketDetailList(basketcheck.Id), basketcheck);
                    return Json("Sepete başarıyla güncellendi.");
                }
                return Json("hide");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }
        [HttpPost]//sepet detayındaki ürün silinir. jsevent.js
        public JsonResult DeleteBasketProduct(BasketDetail basketdetail)
        {
            try
            {
                var d = basketdetailmanager.GetBasketDetail(basketdetail);
                basketdetailmanager.BasketDetailDelete(d);
                basketmanager.UpdateBasket(basketdetailmanager.GetBasketDetailList(d.BasketId), d.Basket);
                return Json("Ürün sepetten başarıyla silindi.");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpPost]//sepet detayında miktar artırma butonu ile miktar artırımı yapılır. jsevent.js
        public IActionResult UpdateBasketProduct(BasketDetail basketdetail)
        {
            try
            {
                var d = basketdetailmanager.BasketDetailUpdate(basketdetail);
                basketmanager.UpdateBasket(basketdetailmanager.GetBasketDetailList(d.BasketId), d.Basket);
                return Json("Ürün detayı başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpGet]//sepetteki ürünün detayını düzenlemek için kullanılır .Sepet detayı modalda gösterilir. jsevent.js
        public JsonResult GetBasketDetail(BasketDetail basketdetail)
        {
            try
            {
                var data = basketdetailmanager.GetBasketDetail(basketdetail);
                return Json(new { success = true, data = data });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpGet]//sepetteki ürünün detayını düzenlemek için kullanılır .Sepet detayı modalda gösterilir. jsevent.js
        public JsonResult GetBasket()
        {
            try
            {
                //kullanıcıda aktif sepet getirilmesi gerekiyor.
                var data = basketmanager.GetBasketList(true).FirstOrDefault();
                return Json(new { success = true, data = data });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpGet]//varyantlı ürünlerin detayını getiren modalı açar
        public JsonResult GetProductSkuList(ProductSku productsku)
        {
            try
            {
                var data = productmanager.GetProductSkuList(Convert.ToInt32(productsku.ProductId));
                return Json(new { success = true, data = data });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }

        [HttpGet]//sepetin yazdırılması için kullanılıyor
        public JsonResult GetBasketDetailPrint()
        {
            try
            {
                //servis tarafına alınması gerekiyor
                var basket = basketmanager.GetBasketList(true).FirstOrDefault();
                if (basket != null)
                {
                    var data = basketdetailmanager.GetBasketDetailList(basket.Id);
                    return Json(new { success = true, data = data });
                }
                else
                {
                    return Json(new { success = true, data = "" });
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpPost]//tahsilat işlemi yapılmaktadır jsevent.js
        public JsonResult Payout(int id, string type)
        {
            try
            {
                if (!string.IsNullOrEmpty(type))
                {
                    Basket basket = basketmanager.GetBasket(id);
                    List<BasketDetail> basketdetail = basketdetailmanager.GetBasketDetailList(id);
                    if (basket != null && basketdetail != null)
                    {
                        if (Convert.ToDouble(basket.InvoiceTotal + basket.InvoicTaxTotal) > 0 && basketdetail.Count > 0)
                        {
                            if (type != "open")
                            {
                                AccountTransaction transaction = new AccountTransaction();
                                transaction.DeptAmount = Convert.ToDouble(basket.InvoiceTotal + basket.InvoicTaxTotal);
                                transaction.CustomerId = basket.CustomerId;
                                Order order = new Order();
                                order.CustomerId = basket.CustomerId;
                                if (type == "cash")
                                {
                                    order.Description = basket.Notes;
                                    transaction = accounttransactionmanager.AddCashPayout(transaction, "NAKTAH");
                                }
                                else if (type == "ccard")
                                {
                                    order.Description = basket.Notes;
                                    transaction.Description = "Kredi Kartı ile Tahsilat";
                                    transaction = accounttransactionmanager.AddCreditCardPayout(transaction);
                                }
                                order = ordermanager.AddOrder(order);
                                foreach (var item in basketdetail)
                                {
                                    OrderDetail detail = new OrderDetail();
                                    var notvatlinetotal = (item.Quantity * (item.UnitPrice - ((item.UnitPrice / 100) * item.Discount))) / (1 + (item.TaxRate / 100));
                                    detail.OrderId = order.Id;
                                    detail.ProductSkusId = item.ProductSkuId;
                                    detail.Quantity = Convert.ToInt32(item.Quantity);//gerçek ortama geçerken double olarak çevrilmeli
                                    detail.UnitPrice = Convert.ToDouble(item.UnitPrice);
                                    detail.UnitNetPrice = Convert.ToDouble(item.Discount == 0 ? item.UnitPrice : item.UnitPrice - ((item.UnitPrice / 100) * item.Discount));
                                    detail.VatRate = Convert.ToInt32(item.TaxRate);
                                    detail.Vat = Convert.ToDouble((item.Quantity * (item.UnitPrice - ((item.UnitPrice / 100) * item.Discount))) - notvatlinetotal);
                                    detail.LineTotalPrice = Convert.ToDouble(item.Quantity * item.UnitPrice);
                                    detail.LineNetPrice = Convert.ToDouble(notvatlinetotal) + Convert.ToDouble(detail.Vat);
                                    detail.Currency = "TL";//döviz birimine göre çekikmesi gerekiyor.
                                    detail.Description = item.Notes;
                                    ordermanager.AddOrderDetail(detail);
                                }
                                basketdetailmanager.DeleteBasketDetail(basketdetail);
                                basketmanager.DeleteBasket(basket);
                                return Json("Ödeme başarıyla tamamlandı.");
                            }
                            else
                            {
                                Order order = new Order();
                                order.CustomerId = basket.CustomerId;
                                order.Description = basket.Notes;
                                order = ordermanager.AddOrder(order);
                                foreach (var item in basketdetail)
                                {
                                    OrderDetail detail = new OrderDetail();
                                    var notvatlinetotal = (item.Quantity * (item.UnitPrice - ((item.UnitPrice / 100) * item.Discount))) / (1 + (item.TaxRate / 100));
                                    detail.OrderId = order.Id;
                                    detail.ProductSkusId = item.ProductSkuId;
                                    detail.Quantity = Convert.ToInt32(item.Quantity);//gerçek ortama geçerken double olarak çevrilmeli
                                    detail.UnitPrice = Convert.ToDouble(item.UnitPrice);
                                    detail.UnitNetPrice = Convert.ToDouble(item.Discount == 0 ? item.UnitPrice : item.UnitPrice - ((item.UnitPrice / 100) * item.Discount));
                                    detail.VatRate = Convert.ToInt32(item.TaxRate);
                                    detail.Vat = Convert.ToDouble((item.Quantity * (item.UnitPrice - ((item.UnitPrice / 100) * item.Discount))) - notvatlinetotal);
                                    detail.LineTotalPrice = Convert.ToDouble(item.Quantity * item.UnitPrice);
                                    detail.LineNetPrice = Convert.ToDouble(notvatlinetotal) + Convert.ToDouble(detail.Vat);
                                    detail.Currency = "TL";//döviz birimine göre çekikmesi gerekiyor.
                                    detail.Description = item.Notes;
                                    ordermanager.AddOrderDetail(detail);
                                }
                                basketdetailmanager.DeleteBasketDetail(basketdetail);
                                basketmanager.DeleteBasket(basket);
                                return Json("Sepet ilgili cariye borçlandırıldı ve kapatıldı.");
                            }
                        }
                        else
                        {
                            throw new Exception("Tutarlı bulunmayan sepet ödemesi gerçekleştirilemez..!");
                        }
                    }
                    else
                    {
                        throw new Exception("Aktif sepet bulunmadığı için ödeme işlemi yapılamaz..!");
                    }



                }
                else
                {
                    throw new Exception("Ödeme tipi boş geçilemez..!");
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }

        [HttpPost]//tahsilat işlemi yapılmaktadır jsevent.js
        public JsonResult PiecedPayout(int id, string json)
        {
            try
            {
                if (!string.IsNullOrEmpty(json))
                {
                    Basket basket = basketmanager.GetBasket(id);
                    List<BasketDetail> basketdetail = basketdetailmanager.GetBasketDetailList(id);
                    if (basket != null && basketdetail != null)
                    {
                        if (Convert.ToDouble(basket.InvoiceTotal + basket.InvoicTaxTotal) > 0 && basketdetail.Count > 0)
                        {
                            List<PaymentDTO> planDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PaymentDTO>>(json);
                            if (planDTO != null && planDTO.Count > 0)
                            {
                                foreach (PaymentDTO item in planDTO)
                                {
                                    AccountTransaction transaction = new AccountTransaction();
                                    transaction.DeptAmount = item.Price;
                                    transaction.CustomerId = basket.CustomerId;
                                    if (item.Type == "Nakit")
                                    {
                                        transaction = accounttransactionmanager.AddCashPayout(transaction, "NAKTAH");
                                    }
                                    else
                                    {
                                        transaction.Description = item.Type + " ile Tahsilat";//siparişe açıklama alanı eklenmeli. sepetten gelen açıklama var.
                                        transaction = accounttransactionmanager.AddCreditCardPayout(transaction);
                                    }
                                    GC.SuppressFinalize(transaction);
                                }
                                Order order = new Order();
                                order.CustomerId = basket.CustomerId;
                                order.Description = basket.Notes;
                                order = ordermanager.AddOrder(order);

                                foreach (var item in basketdetail)
                                {
                                    OrderDetail detail = new OrderDetail();
                                    var notvatlinetotal = (item.Quantity * (item.UnitPrice - ((item.UnitPrice / 100) * item.Discount))) / (1 + (item.TaxRate / 100));
                                    detail.OrderId = order.Id;
                                    detail.ProductSkusId = item.ProductSkuId;
                                    detail.Quantity = Convert.ToInt32(item.Quantity);//gerçek ortama geçerken double olarak çevrilmeli
                                    detail.UnitPrice = Convert.ToDouble(item.UnitPrice);
                                    detail.UnitNetPrice = Convert.ToDouble(item.Discount == 0 ? item.UnitPrice : item.UnitPrice - ((item.UnitPrice / 100) * item.Discount));
                                    detail.VatRate = Convert.ToInt32(item.TaxRate);
                                    detail.Vat = Convert.ToDouble((item.Quantity * (item.UnitPrice - ((item.UnitPrice / 100) * item.Discount))) - notvatlinetotal);
                                    detail.LineTotalPrice = Convert.ToDouble(item.Quantity * item.UnitPrice);
                                    detail.LineNetPrice = Convert.ToDouble(notvatlinetotal) + Convert.ToDouble(detail.Vat);
                                    detail.Currency = "TL";//döviz birimine göre çekikmesi gerekiyor.
                                    detail.Description = item.Notes;
                                    ordermanager.AddOrderDetail(detail);
                                }
                                basketdetailmanager.DeleteBasketDetail(basketdetail);
                                basketmanager.DeleteBasket(basket);
                                return Json("Ödeme başarıyla tamamlandı.");

                            }
                            else
                            {
                                throw new Exception("Tutarsız ödeme listesi işlenemez..");
                            }
                        }
                        else
                        {
                            throw new Exception("Tutarlı bulunmayan sepet ödemesi gerçekleştirilemez..!");
                        }
                    }
                    else
                    {
                        throw new Exception("Aktif sepet bulunmadığı için ödeme işlemi yapılamaz..!");
                    }



                }
                else
                {
                    throw new Exception("Parçalı ödeme boş geçilemez..");
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }

        [HttpGet]//sipariş iade detayını getirmek için kullanılır . jsevent.js
        public JsonResult GetOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                if (orderDetail != null)
                {
                    var data = ordermanager.GetOrderDetailList(orderDetail.OrderId);
                    return Json(new { success = true, data = data });
                }
                else
                {
                    throw new Exception("Model not found!");
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpGet]//Bugün yapılan satışları gösterir. Modal içinde gösterilir. jsevent.js
        public JsonResult GetOrderWithSearch(string value)
        {
            try
            {
                return Json(new { success = true, data = ordermanager.GetOrderList(null, value) });
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpPost]//iade sipariş için temp tabloya seçilen kayıtları atar. jsevent.js
        public IActionResult AddReturnOrderTemp(string json)
        {
            try
            {
                if (!string.IsNullOrEmpty(json))
                {
                    var data = JsonConvert.DeserializeObject<List<ReturnOrderDTO>>(json);
                    if (data.Count > 0)
                    {
                        double? total = 0;
                        Order order = ordermanager.GetOrder(data[0].OrderId);
                        ReturnOrder returnorder = new ReturnOrder();
                        returnorder.Status = false;
                        returnorder.CustomerId = order.CustomerId;
                        returnorder.Description = order.Id.ToString() + " numaralı siparişin iadesidir.";
                        returnorder = returnordermanager.AddOrder(returnorder);
                        foreach (var item in data)
                        {
                            OrderDetail orderdetail = ordermanager.GetOrderDetail(item.OrderDetailId);
                            ReturnOrderDetail returnorderdetail = new ReturnOrderDetail();
                            var notvatlinetotal = (item.Quantity * orderdetail.UnitPrice) / (1 + (orderdetail.VatRate / 100));
                            returnorderdetail.OrderId = returnorder.Id;
                            returnorderdetail.ProductSkusId = item.ProductSkusId;
                            returnorderdetail.Quantity = Convert.ToInt32(item.Quantity);//gerçek ortama geçerken double olarak çevrilmeli
                            returnorderdetail.UnitPrice = Convert.ToDouble(orderdetail.UnitPrice);
                            returnorderdetail.UnitNetPrice = Convert.ToDouble(orderdetail.UnitPrice);
                            returnorderdetail.VatRate = Convert.ToInt32(orderdetail.VatRate);
                            returnorderdetail.Vat = Convert.ToDouble((item.Quantity * orderdetail.UnitPrice) - notvatlinetotal);
                            returnorderdetail.LineTotalPrice = Convert.ToDouble(item.Quantity * orderdetail.UnitPrice);
                            returnorderdetail.LineNetPrice = Convert.ToDouble(notvatlinetotal) + Convert.ToDouble(returnorderdetail.Vat);
                            returnorderdetail.Currency = "TL";//döviz birimine göre çekikmesi gerekiyor.
                            returnorderdetail.Description = "";//iade açıklaması gelebilir.
                            returnordermanager.AddOrderDetail(returnorderdetail);
                            total += returnorderdetail.LineNetPrice;
                        }
                        return Json(new { success = true, data = new Tuple<double?, int>(total, returnorder.Id) });
                    }
                    else
                    {
                        throw new Exception("Veri bulunamadı!.");
                    }
                }
                else
                {
                    throw new Exception("Veri bulunamadı!.");
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }

        }
        [HttpPost]//tahsilat işlemi yapılmaktadır jsevent.js
        public JsonResult ReturnPayout(int id, string type)
        {
            try
            {
                if (!string.IsNullOrEmpty(type))
                {
                    ReturnOrder returnOrder = returnordermanager.GetReturnOrder(id);
                    List<ReturnOrderDetail> returnOrderDetail = returnordermanager.GetReturnOrderDetailList(id);
                    if (returnOrder != null && returnOrderDetail.Count > 0)
                    {
                        returnOrder.Status = true;
                        returnordermanager.UpdateReturnOrder(returnOrder);
                        if (type != "open")
                        {

                            AccountTransaction transaction = new AccountTransaction();
                            transaction.DeptAmount = Convert.ToDouble(returnOrderDetail.Sum(s => s.LineNetPrice));
                            transaction.CustomerId = returnOrder.CustomerId;
                            transaction.Description = id.ToString() + " numaralı iadenin ödemesidir.";
                            if (type == "cash")
                            {
                                transaction = accounttransactionmanager.AddCashPayout(transaction, "NAKÖDE");
                            }
                            else if (type == "ccard")
                            {
                                transaction.Description = "Kredi Kartı ile Ödeme";
                                transaction = accounttransactionmanager.AddCreditCardPayout(transaction);
                            }
                            return Json("Ödeme başarıyla tamamlandı.");
                        }
                        else
                        {
                            return Json("İade ilgili cariye alacaklandırıldı ve kapatıldı.");
                        }

                    }
                    else
                    {
                        throw new Exception("Aktif iade bulunmadığı için ödeme işlemi yapılamaz..!");
                    }
                }
                else
                {
                    throw new Exception("Ödeme tipi boş geçilemez..!");
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }

        [HttpPost]//tahsilat işlemi yapılmaktadır jsevent.js
        public JsonResult ReturnPiecedPayout(int id, string json)
        {
            try
            {
                if (!string.IsNullOrEmpty(json))
                {
                    ReturnOrder returnOrder = returnordermanager.GetReturnOrder(id);
                    List<ReturnOrderDetail> returnOrderDetail = returnordermanager.GetReturnOrderDetailList(id);
                    if (returnOrder != null && returnOrderDetail != null)
                    {

                        List<PaymentDTO> planDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PaymentDTO>>(json);
                        if (planDTO != null && planDTO.Count > 0)
                        {
                            foreach (PaymentDTO item in planDTO)
                            {
                                AccountTransaction transaction = new AccountTransaction();
                                transaction.DeptAmount = item.Price;
                                transaction.CustomerId = returnOrder.CustomerId;
                                if (item.Type == "Nakit")
                                {
                                    transaction = accounttransactionmanager.AddCashPayout(transaction, "NAKÖDE");
                                }
                                else
                                {
                                    transaction.Description = item.Type + " ile Tahsilat";//siparişe açıklama alanı eklenmeli. sepetten gelen açıklama var.
                                    transaction = accounttransactionmanager.AddCreditCardPayout(transaction);
                                }
                                GC.SuppressFinalize(transaction);
                            }
                            return Json("Ödeme başarıyla tamamlandı.");

                        }
                        else
                        {
                            throw new Exception("Tutarsız ödeme listesi işlenemez..");
                        }

                    }
                    else
                    {
                        throw new Exception("Aktif iade işlemi bulunmadığı için ödeme işlemi yapılamaz..!");
                    }
                }
                else
                {
                    throw new Exception("Parçalı ödeme boş geçilemez..");
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Json(new { success = false, responseText = ex.Message });
            }
        }
    }
}
