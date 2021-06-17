using System;
using System.Text;

namespace JURNAL_13
{
    public class Pengguna
    {
        // Variables
        private string _username;
        private int _noHP;
        private string _email;
        private string _katasandi;

        // Pembuatan data dari parameter

        //container
        public Pengguna(string username, int noHP, string email, string katasandi)
        {
            _username = username;
            _noHP = noHP;
            _email = email;
            _katasandi = katasandi;

            try
            {
                _katasandi = katasandi;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Inputa salah", e.Message);
            }
            Console.ReadLine();
            }
        

            // Return  data_username

            public String getUsername()
        {
            return _username;
        }

        // Penyimpanan data username dengan parameter 

        public void setUsername(String username)
        {
            this._username = username;
        }

        // Return Data _nohp

        public int getNohp(String noHP)
        {
            return _noHP;
        }

        // Penyimpanan data nohp dengan parameter 

        public void SetnoHP(int noHP)
        {
            this._noHP = noHP;
        }
        // Return Data _email

        public String getemail(String email)
        {
            return _email;
        }

        // Penyimpanan data email dengan parameter 

        public void setemail(String email)
        {
            this._email = email;
        }



        // Return Data _katasandi

        public String getkatasandi(String katasandi)
        {
            return _katasandi;
        }


        // Penyimpanan data email dengan parameter 

        public void setkatasandi(String katasandi)
        {
            this._katasandi = katasandi;
        }
        
    }
}