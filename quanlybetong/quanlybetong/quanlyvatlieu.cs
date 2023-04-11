using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlybetong
{
    public class quanlyvatlieu
    {
        public string STT { get; set; }
        public string Name { get; set; }
        public string Chieucao { get; set; }
        public string chieudai { get; set; }
        public string berong { get; set; }

        private double m_ChieuCao = 0;
        private double m_ChieuDai = 0;
        private double m_ChieuRong = 0;
        public double ChieuCao
        {
            get
            {
                return m_ChieuCao;
            }

            set
            {
                m_ChieuCao = value;
            }
        }

        public double ChieuDai
        {
            get
            {
                return m_ChieuDai;
            }

            set
            {
                m_ChieuDai = value;
            }
        }

        public double ChieuRong
        {
            get
            {
                return m_ChieuRong;
            }

            set
            {
                m_ChieuRong = value;
            }
        }

        #region "Phương thức"
        public double DienTich()
        {
            //double chieucao = double.Parse(Chieucao);
            //double chieurong = double.Parse(berong);
            //double chieuDai = double.Parse(chieudai);
            return m_ChieuCao * m_ChieuDai * m_ChieuRong;
        }
        public bool KiemTra(double Stc)
        {
            if (DienTich() < Stc)
            {
                return false;
            }
            else return true;
        }
        #endregion
    }
}
