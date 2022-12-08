﻿using PhanMemQuanLyGaraOto.DAO;
using PhanMemQuanLyGaraOto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyGaraOto.DDo
{
    public class DDOpassword
    {
        private static DDOpassword ins;

        public static DDOpassword Ins { 
            get
            {
                if (ins == null) ins = new DDOpassword();
                return ins;
            } 
            private set => ins = value; 
        }
        private DDOpassword() { }
        public bool CheckPassWord(string userName, string passWord, out ACCOUNT aCCOUNT)
        {
            var ListUser = DataProvider.Instance.db.LOGINACCOUNT(userName,SuperHash.GetHashPassWord(passWord)).ToList();
            if (ListUser.Count == 0)
            {
                aCCOUNT = null;
                return false;
            }
            var userGet = ListUser.FirstOrDefault();
            aCCOUNT = new ACCOUNT { USERNAME = userGet.USERNAME, USERID = userGet.USERID, DISPLAYNAME = userGet.DISPLAYNAME, DESCRIPTION = userGet.DESCRIPTION, TYPE = userGet.TYPE, PASSWORD = userGet.PASSWORD };
            return true;
           
        }
    }
}
