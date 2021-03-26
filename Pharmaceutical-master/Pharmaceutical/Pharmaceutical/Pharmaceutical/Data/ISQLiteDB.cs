using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmaceutical.Data
{
    public interface ISQLiteDB
    {
        //============================================= 
        // Reference C1: externally sourced code 
        // getting connected to SQLite 
        // Date: 5 Sep 2018
        // Source: Mobile Local Databases In Xamarin.Forms Using SQLite
        // Author: Suthahar J
        // url: https://www.c-sharpcorner.com/article/mobile-local-databases-in-xamarin-forms-using-sqlite/

        //============================================= 


        SQLiteConnection GetConnection();
    }
}
