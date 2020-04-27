﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SmartFactory.Models.Repository;
using System.Security.Cryptography;
using SmartFactory.Models;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace SmartFactory.Controllers
{
    public class UserController //: Controller
    {
        private static Repository repository = new Repository();
        private IEnumerable<User> users = repository.Users;


        public string Encrypt(string p)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(p);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string finaliized = Convert.ToBase64String(tmpHash);
            return finaliized;
        }

        ///TODO: Превратить Viewbag в пуши (уведомления окошками). 
        ///Придумать как обойти request (или просто переписать всю функцию нормально без хттп-хлама)

        /*
        public bool Register()
        {
            User guest = new User();
            NameValueCollection coll;
            coll = Request.Form;
            string pwd = Encrypt(coll["Password"]);
            bool fuckup = false;
            //ViewBag.Message = "Registration failed. Problems occured:";
            bool ifmaker = false;
            bool ifcustomer = false;
            if (coll["IfMaker"] == "on")
                ifmaker = true;
            if (coll["IfCustomer"] == "on")
                ifcustomer = true;
            if (!Regex.IsMatch(coll["Email"],
              @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
              RegexOptions.IgnoreCase))
            {
                ViewBag.Message += "\nEmail is not valid";
                fuckup = true;
            }
            if (coll["Name"].Length < 3 || coll["Name"].Length > 25)
            {
                ViewBag.Message += "\nUsername must be between 3 and 25 units long";
                fuckup = true;
            }
            if (coll["Password"].Length < 6)
            {
                ViewBag.Message += "\nPassword must contain 6 or more units";
                fuckup = true;
            }
            if (repository.IsUserExist(coll["Email"]))
            {
                ViewBag.Message += "\nUser with such email aready exists";
                fuckup = true;
            }
            if (repository.IsUserExist(coll["Name"]))
            {
                ViewBag.Message += "\nUser with such username aready exists";
                fuckup = true;
            }
            if (!ifmaker && !ifcustomer)
            {
                ViewBag.Message += "\nYour role is not selected. At least one role needs to be applied";
                fuckup = true;
            }
            if (!fuckup)
            {
                guest.Email = coll["Email"];
                guest.Password = pwd;
                guest.Name = coll["Name"];
                guest.IfMaker = ifmaker;
                guest.IfCustomer = ifcustomer;
                repository.CreateUser(guest);
                User dummy = new User();
                dummy.Name = guest.Name;
                Session["UserId"] = guest.ID;
                return RedirectToAction("RegComplete", dummy);
            }
            else
            {
                ViewBag.Message += "\nPlease, try again";
                return View();
            }
            
        }*/
    }
}
