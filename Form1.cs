using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quản_lý_điểm_học_sinh
{
    public partial class Form1 : Form
    {
        private List<HOCSINH> danhsachHS = new List<HOCSINH>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1_danhsach.Columns.Add("STT", "STT");
            dataGridView1_danhsach.Columns.Add("HoTen", "Họ Tên");
            dataGridView1_danhsach.Columns.Add("DiemVan", "Điểm Văn");
            dataGridView1_danhsach.Columns.Add("DiemToan", "Điểm Toán");
            dataGridView1_danhsach.Columns.Add("DiemTB", "Điểm Trung Bình");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_themtths_Click(object sender, EventArgs e)
        {
            string hoten = textBox1_HoTen.Text.Trim();
            double van, toan;


            if (hoten == "")
            {
                MessageBox.Show("Vui Lòng Nhập Họ Tên ");
                textBox1_HoTen.Focus();
                return;


            }
            if (!double.TryParse(textBox2_DiemVan.Text, out van) || van < 0 || van > 10)
            {
                MessageBox.Show("Điểm Văn Không hợp lệ ");
                textBox2_DiemVan.Focus();
                return;
            }
            if
               (!double.TryParse(textBox3_DiemVan.Text, out toan) || toan < 0 || toan > 10)
            {
                MessageBox.Show("Điểm Toán không hợp lệ ");
                textBox3_DiemVan.Focus();
                return;
            }
            HOCSINH hs = new HOCSINH(hoten, van, toan);

            danhsachHS.Add(hs);
            int stt = danhsachHS.Count;
            dataGridView1_danhsach.Rows.Add(stt, hs.HoTen, hs.DiemVan, hs.DiemToan, hs.TinhDiemTB());


            textBox1_HoTen.Clear();
            textBox2_DiemVan.Clear();
            textBox3_DiemVan.Clear();
            textBox1_HoTen.Focus();














        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_luu_Click(object sender, EventArgs e)
        {
            if (danhsachHS.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để lưu !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // chọn đường dẫn lưu file
            string filepath = "hoc_sinh.txt";

            //dùng streamwriter để ghi dữ liệu ra file 
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                int stt = 1;
                foreach (var hs in danhsachHS)
                {
                    writer.WriteLine(stt + ". " + hs.HoTen + " - Văn: " + hs.DiemVan + " - Toán: " + hs.DiemToan + " - TB: " + hs.TinhDiemTB());
                    stt++;
                }
            }
            MessageBox.Show("đã lưu danh sách thành công ", "Thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_mobai_Click(object sender, EventArgs e)
        {
            string filepath = "hoc_sinh.txt";

            if (!File.Exists(filepath))
            {
                MessageBox.Show("Chưa có file để mở", "thông báo");
                return;
            }
            danhsachHS.Clear();
            dataGridView1_danhsach.Rows.Clear();

            string[] lines = File.ReadAllLines(filepath);
            int stt = 1;
            foreach (string line in lines)
            {
                try
                {
                    string[] parts = line.Split('-');
                    if (parts.Length >= 3)
                    {
                        string hoten = parts[0].Split('.')[1].Trim();
                        string vanText = parts[1].Replace("Văn:", "").Trim();
                        double van = double.Parse(vanText);
                        string toanText = parts[2].Replace("Toán:", "").Trim();
                        double toan = double.Parse(toanText);


                        HOCSINH hs = new HOCSINH(hoten, van, toan);
                        danhsachHS.Add(hs);

                        dataGridView1_danhsach.Rows.Add(stt, hs.HoTen, hs.DiemVan, hs.DiemToan, hs.TinhDiemTB());
                        stt++;
                    }
                }
                catch
                {

                    continue;
                }
            }

            MessageBox.Show("đã mở file thành công");
        }

        private void button1_xoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa tất cả dữ liệu trong bảng không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {

                dataGridView1_danhsach.Rows.Clear();



                MessageBox.Show("Đã xóa hết dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_luubai_c2_Click(object sender, EventArgs e)
        {
            // Tạo một biến tên là saveFileDialog (có thể dùng tên khác) kiểu SaveFileDialog.
            // Biến này dùng để hiển thị cửa sổ " lưu file " cho người dùng chọn nới lưu dữ liệu.
             SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            // Đặt tiêu đề cho cửa sổ lưu file(hiển thị ở thanh trên cùng của hộp thoại).
             saveFileDialog.Title = "Lưu file";
            
            // Chỉ định loại file cho phép lưu 
            // "Text Files (*.txt)|*.txt -> chỉ hiện file .txt
            // All Files (*.*)|*.* -> hiện tất cả các file
             saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            
            
            // Đặt mặc định đuôi cho file nếu người dùng quen không gõ đuôi txt chương trình sẽ tự thêm đuôi txt vào 
             saveFileDialog.DefaultExt = "txt";
           
            
            // Nếu người dùng quên gõ đuôi txt thì chương trình sẽ tự thêm đuôi txt vào file đó Vd: danhsach -> sẽ tự thành "danhsach.txt"
             saveFileDialog.AddExtension = true;
            
            
            // Hiển thị cửa sổ " Save As" cho người dùng 
            // Nếu người dùng bấm OK thì thực hiện các lệnh bên trong 
             if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                 // Tạo một biến tên là filepath kiểu string 
                 // để chứa đường dẫn đầy đủ và tên file mà người dùng chọn để lưu 
                 string filePath = saveFileDialog.FileName;
                 // Tạo một danh sách để chứa từng dòng dữ liệu từ bảng.
                 List<string> lines = new List<string>();
        
                 
        //Duyệt từng hàng (DataGridViewRow) trong bảng dataGridView1_danhsach
        //để lấy dữ liệu mà người dùng đã nhập, chuẩn bị lưu vào file  
        foreach (DataGridViewRow row in dataGridView1_danhsach.Rows)
        {
            // Bỏ qua hàng mới trống( chưa nhập gì )
            if (row.IsNewRow) continue; 
            
            
            // Tạo biến line kiểu string để chứa dữ liệu của 5 cột trong 1 hàng.
            // Nếu ô nào trống thì thay bằng chuỗi rỗng "".
            // Dùng "/t" để ngăn cách các cột, khi lưu ra file dễ nhìn.
            string line =
                (row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "") + "\t" +
                (row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "") + "\t" +
                (row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "") + "\t" +
                (row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "") + "\t" +
                (row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "");
             
            // Thêm dòng vừa tạo vào danh sách line 
            lines.Add(line);
        }

        // Ghi tất cả dòng trong "lines" vào file "filepath" 
        File.WriteAllLines(filePath, lines);
        // Hiển thị thông báo đã lưu file thành công, kèm đường dẫn file.
        MessageBox.Show("Đã lưu file thành công tại:\n" + filePath);
    }
    }
    
        
   


        private void button1_mobai_c2_Click(object sender, EventArgs e)
        {
       // Biến này dùng để hiển thị cửa sổ " mở file " cho người dùng chọn nơi mở dữ liệu.
    OpenFileDialog openFileDialog = new OpenFileDialog();
      
    // Thiết lập tiêu đề cho hộp thoại.
    openFileDialog.Title = "Chọn file cần mở";
    
            
     // Chỉ định loại file cho phép mở:
    // chỉ mở file .txt ->Text Files (*.txt)|*.txt
    //, .csv-> CSV Files (*.csv)|*.csv
    // tất cả các file ->  All Files (*.*)|*.*"
    openFileDialog.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
    
            // Thiết lập thư mục mặc định khi mở hộp thoại 
            // khi người dùng bấm " Mở file" cửa sổ sẽ hiển thị thư mục chứa chương trình 
    openFileDialog.InitialDirectory = Application.StartupPath;

    
  
        // Mở hộp thoại để người dùng chọn file , nếu người dùng chọn oke thì thực hiện các lệnh bên trong.
        if (openFileDialog.ShowDialog() == DialogResult.OK)

        {
            // Tạo một biến tên là filepath kiểu string
            // Biến này sẽ lưu " đường dẫn đầy đủ và tên file " mà người dùng đã chọn.
            string filePath = openFileDialog.FileName;
            
            // Tạo một mảng biến kiểu string " lines "
            // Mảng này sẽ chứa tất cả các dòng trong file mà chương trình vừa mở
            // File.ReadALLlines(filepath) đọc toàn bộ nội dùng file 
            string[] lines = File.ReadAllLines(filePath);

            // Kiểm tra xem dataGridView đã có cột chưa
            // Nếu chưa có cột nào thì tạo cột mới 
            if (dataGridView1_danhsach.ColumnCount == 0)
            {    // Tạo 5 cột cho datagridview 
                dataGridView1_danhsach.ColumnCount = 5;
                // Tạo cột stt
                dataGridView1_danhsach.Columns[0].Name = "STT";
                // Tạo cột Họ Tên
                dataGridView1_danhsach.Columns[1].Name = "Họ Tên";
                // Tạo cột Điểm Văn 
                dataGridView1_danhsach.Columns[2].Name = "Điểm Văn";
                // Tạo cột Điểm Toán 
                dataGridView1_danhsach.Columns[3].Name = "Điểm Toán";
                // Tạo cột điểm TB 
                dataGridView1_danhsach.Columns[4].Name = "Điểm Trung Bình ";
            }
            // Xóa hết các dòng dữ liệu cũ trước khi thêm dữ liệu mới 
            dataGridView1_danhsach.Rows.Clear();
            
            // Duyệt từng dòng trong mảng " Lines " ( mỗi dòng là một phần tử của file )
            foreach (string line in lines)
            {
                // Tách dòng thành các phần nhỏ dựa trên dựa trên ký tự tab (\t)
                // Nếu file CSV dùng dấu ' , ' thì thay bằng line.Split(',')
                string[] parts = line.Split('\t');

                // Kiểm tra xem dòng này có đủ 5 phần dữ liệu (STT, Họ Tên, Văn, Toán, TB)
                if (parts.Length >= 5)
                {
                    // Thêm một dòng mới vào DataGridView với dữ liệu file
                    //parts(0) -> STT
                    //parts(1) -> Họ Tên
                    //parts(2) -> Điểm Văn
                    //parts(3) -> Điểm Toán
                    //parts(4) -> Điểm Trung Bình
                    dataGridView1_danhsach.Rows.Add(parts[0], parts[1], parts[2], parts[3],parts[4]);
                }
            }
            // Hiển thị thông báo cho người dùng biết file đã mở thành công 
            MessageBox.Show("Đã mở file: " + filePath);
        };
}
        }
    }

    



    
    
        

        
    

