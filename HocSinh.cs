using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_quan_ly_hoc_sinh
{
    public class HocSinh
    {
        private String m_mshs; // Ma So Hoc Sinh
        private string m_hoten;// Ho Va Ten Hoc SInh
        private DateTime m_ngaysinh; // Ngay Sinh
        private bool m_phai; // Phái
        private string m_diachi; // Dia chi 
        //Phuong thuc tao lap, Khoi tao cac gia trij ban dau cho cac thanh phan du lieu cua doi tuong, Ten Cua phuong thuc tao lap phai trung voi ten lop doi tuong (class HocSinh)
        //Co 5 tham so tuong ung voi 5 doi tuong
        public HocSinh()
        {
            m_mshs = string.Empty;
            m_hoten = string.Empty;
            m_ngaysinh = DateTime.Now;
            m_phai = false;
            m_diachi = string.Empty;
        }
        public HocSinh(String mshs, String hoten, DateTime ngaysinh, bool phai, string diachi)
        {
            m_mshs = mshs;
            m_hoten = hoten;
            m_ngaysinh = ngaysinh;
            m_phai = phai;
            m_diachi = diachi;
        }

        //Xay dung 5 properties de update cac du lieu tren

        public string mshs
        {
            get { return m_mshs; }
            set { m_mshs = value; }
        }
        public string hoten
        {
            get { return m_hoten; }
            set { m_hoten = value; }
        }
        public DateTime ngaysinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }
        public bool phai
        {
            get { return m_phai; }
            set { m_phai = value; }
        }
        public string diachi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }



    }

}
