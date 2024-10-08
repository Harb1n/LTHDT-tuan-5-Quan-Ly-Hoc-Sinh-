using CTDL_quan_ly_hoc_sinh;

namespace QLDL_HocSinh
{
    public partial class QuanLyHocSinh : Form
    {
        private List<HocSinh> ds;
        public QuanLyHocSinh()
        {
            InitializeComponent();
        }
        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            ds = new List<HocSinh>();
        }



        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;/// Lien Ket giua ds va biding source, sau khi tao xong lien ket, tao lien ket bs => Data grid view
            dgv.DataSource = bs; /// dgv = datagridview

             /// tao lien ket cua tung cot + cac doi tuong cua ds(aka properties), ghi ten thuoc tinh dung de bind.
            /// vao Data grid box, bam vao tam giac -> edit collum, Kiem DataProperty -> viet ten thuoc tinh ( Viet dung ten thuoc tinh)
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}