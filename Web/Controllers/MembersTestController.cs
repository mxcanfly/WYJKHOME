using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MembersTestController : Controller
    {
        private ADOModel1 db = new ADOModel1();

        // GET: MembersTest
        public ActionResult Index()
        {
            return View(db.Members.ToList());
        }

        // GET: MembersTest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // GET: MembersTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembersTest/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemberID,MemberName,MemberPhone,Password,InviteCode,IsComplete,TrueName,CertificateType,CertificateNo,PoliticalStatus,Education,Birthday,Sex,Address,Phone,Email,QQ,Alipay,BankCardNo,BankAccount,UserAccount,SecondContact,SecondContactPhone,InsuranceArea,HouseholdType,Fax,BusinessCode,BusinessIdentityCardNo,BusinessName,BusinessUser,BusinessIdentityPhoto,BusinessLicensePhoto,EnterpriseApplyName,EnterpriseApplyIdentityCardNo,EnterpriseApplyIdentityPhoto,EnterpriseApplyUserPhone,EnterpriseApplyUserEmail,EnterpriseLicensePhone,EnterpriseName,EnterpriseType,EnterpriseArea,EnterpriseLegal,EnterpriseLegalIdentityCardNo,EnterprisePeopleNum,SocialSecurityCreditCode,EnterpriseIsThreeInOne,EnterpriseBusinessLicense,EnterpriseTaxRegistrationCertificate,EnterpriseOrganizationCodeCertificate,EnterpriseFixedTelePhone,IsAuthentication,UserType,TaxpayerName,TaxNumber,ContactUser,ContactUserPhone,OpenAccountPhone,Account,SocialSecurityAmount,AccumulationFundAmount,ServiceCost,FirstBacklogCost,Bucha,HeadPortrait")] Members members)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(members);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(members);
        }

        // GET: MembersTest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // POST: MembersTest/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MemberID,MemberName,MemberPhone,Password,InviteCode,IsComplete,TrueName,CertificateType,CertificateNo,PoliticalStatus,Education,Birthday,Sex,Address,Phone,Email,QQ,Alipay,BankCardNo,BankAccount,UserAccount,SecondContact,SecondContactPhone,InsuranceArea,HouseholdType,Fax,BusinessCode,BusinessIdentityCardNo,BusinessName,BusinessUser,BusinessIdentityPhoto,BusinessLicensePhoto,EnterpriseApplyName,EnterpriseApplyIdentityCardNo,EnterpriseApplyIdentityPhoto,EnterpriseApplyUserPhone,EnterpriseApplyUserEmail,EnterpriseLicensePhone,EnterpriseName,EnterpriseType,EnterpriseArea,EnterpriseLegal,EnterpriseLegalIdentityCardNo,EnterprisePeopleNum,SocialSecurityCreditCode,EnterpriseIsThreeInOne,EnterpriseBusinessLicense,EnterpriseTaxRegistrationCertificate,EnterpriseOrganizationCodeCertificate,EnterpriseFixedTelePhone,IsAuthentication,UserType,TaxpayerName,TaxNumber,ContactUser,ContactUserPhone,OpenAccountPhone,Account,SocialSecurityAmount,AccumulationFundAmount,ServiceCost,FirstBacklogCost,Bucha,HeadPortrait")] Members members)
        {
            if (ModelState.IsValid)
            {
                db.Entry(members).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(members);
        }

        // GET: MembersTest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // POST: MembersTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Members members = db.Members.Find(id);
            db.Members.Remove(members);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
