using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Generic_Interface
    {
    }
    class MySQLdata : IMySQLdata  // bunu yazmak yeerine direk Idatabaseyide yazabilirdik ama bu sefer farklı bir tanım atamak istesek sınıfa bunu yapmak için data base içerisinden değişiklik yapmak gerekirdi.
    {
        public void Add(MySQLdata parametre)
        {
            throw new NotImplementedException();
        }

        public void Delete(MySQLdata parametre)
        {
            throw new NotImplementedException();
        }

        public MySQLdata Get(MySQLdata parametre)
        {
            throw new NotImplementedException();
        }

        public void Update(MySQLdata parametre)
        {
            throw new NotImplementedException();
        }
    }
    interface IMySQLdata : IDataBaseDepo<MySQLdata>
    {
        //MySQLdata Get(MySQLdata parametre);       
        //void Add(MySQLdata parametre);
        //void Delete(MySQLdata parametre);
        //void Update(MySQLdata parametre);
    }
    class MSSQLdata : IMSSQLdata    //  aynı datayı iki farklı alt yapı için tek tek yazmaktan 3. olarak generic interface kullanıcam   (kapalı olan kodlar normalde uzun uzun yapmam gereken işlerdi.)
    {
        public void Add(MSSQLdata parametre)
        {
            throw new NotImplementedException();
        }

        public void Delete(MSSQLdata parametre)
        {
            throw new NotImplementedException();
        }

        public MSSQLdata Get(MSSQLdata parametre)
        {
            throw new NotImplementedException();
        }

        public void Update(MSSQLdata parametre)
        {
            throw new NotImplementedException();
        }
    }
    interface IMSSQLdata : IDataBaseDepo<MSSQLdata>   // IMSSQLdata yı kopyalıp class a yapıştırfım  daha sonra alt + enter dedim ve ara birimi uygulayı seçtim. class ı benim yerime otomatik program doldurdu.
    {
        //MSSQLdata Get(MSSQLdata parametre);
        //void Add(MSSQLdata parametre);
        //void Delete(MSSQLdata parametre);
        //void Update(MSSQLdata parametre);

    }
    interface IDataBaseDepo<T>
    {
        T Get(T parametre);
        void Add(T parametre);
        void Delete(T parametre);
        void Update(T parametre);

    }
}
