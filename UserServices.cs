using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Services
{
    public class UserServices
    {
        
        public List<Musteriler> GetAllList()
        {

            using (var kullanıcı = new Models.KullanıcılarContext())
            {
                return kullanıcı.Musterilers.ToList();

            }


        }
        public Musteriler GetById(int Id)
        {
            Musteriler Musteri_Id = new Musteriler();
            using (var src = new KullanıcılarContext())
            {
                Musteri_Id = src.Musterilers.FirstOrDefault(a => a.Id == Id);

            }
            return Musteri_Id;
        }
    }
}
