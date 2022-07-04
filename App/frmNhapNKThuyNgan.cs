using Library.DataAccessLayer.Models;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordToPDF;
namespace App
{
    public partial class frmNhapNKThuyNgan : Form
    {
        public frmNhapNKThuyNgan()
        {
            InitializeComponent();
        }

        private void InputNumberOnly(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);
        }

        private void txtT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);
        }

        private void txtT2_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);
        }

        private void txtT2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);
        }

        private void txtT1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtT2_TextChanged(object sender, EventArgs e)
        {
            float t2;
            float t2_1;
            float t2_2;
            if (float.TryParse(txtT2.Text, out t2))
            {
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    if (float.TryParse(txtT2_1.Text, out t2_1))
                        current.T2ptt2 = (t2_1 - t2).ToString();
                    if (float.TryParse(txtT2_2.Text, out t2_2))
                        current.T2pptt2 = (t2_2 - t2).ToString();
                }
            }
        }

        private void txtT2_1_TextChanged(object sender, EventArgs e)
        {
            float t2;
            float t2_1;
            float t2_2;
            if (float.TryParse(txtT2_1.Text, out t2_1))
            {
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    if (float.TryParse(txtT2_2.Text, out t2_2))
                        current.T2pptt2p = (t2_2 - t2_1).ToString();
                    if (float.TryParse(txtT2.Text, out t2))
                        current.T2ptt2 = (t2_1 - t2).ToString();
                }
            }
        }

        private void txtT2_2_TextChanged(object sender, EventArgs e)
        {
            float t2;
            float t2_1;
            float t2_2;
            if (float.TryParse(txtT2_2.Text, out t2_2))
            {
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    if (float.TryParse(txtT2_1.Text, out t2_1))
                        current.T2pptt2p = (t2_2 - t2_1).ToString();
                    if (float.TryParse(txtT2.Text, out t2))
                        current.T2pptt2 = (t2_2 - t2).ToString();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtMinI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);

        }

        float _minI1;
        float MinI1
        {
            get => _minI1; set
            {
                _minI1 = value;
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    current.Cllnmin = (MinI2 - MinI1).ToString();
                }
            }
        }

        float _minI2;
        float MinI2
        {
            get => _minI2; set
            {
                _minI2 = value;
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    current.Cllnmin = (MinI2 - MinI1).ToString();
                }
            }
        }

        private void txtMinI1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtMinI1.Text, out float MinI1))
            {
                this.MinI1 = MinI1;
            }
        }

        private void txtMinI2_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtMinI2.Text, out float MinI2))
            {
                this.MinI2 = MinI2;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNkthuynganBindingSource.Current is TbNkthuyngan nkthuyngan)
            {
                using (var context = new TestContext())
                {
                    if (string.IsNullOrWhiteSpace(nkthuyngan.So))
                    {
                        MessageBox.Show($"Số không thể để trống!", "Thông báo");
                        return;
                    }
                    if (context.TbNkthuyngans.Any(nk => nk.So == nkthuyngan.So))
                    {
                        MessageBox.Show($"Nhiệt kế có số {nkthuyngan.So} đã tồn tại.", "Thông báo");
                        return;
                    }
                    context.TbNkthuyngans.Add(nkthuyngan);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Lưu thành công.", "Thông báo");
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSo.ReadOnly = false;
            tbNkthuynganBindingSource.AddNew();
        }

        private void frmNhapNKThuyNgan_Load(object sender, EventArgs e)
        {
            if (tbNkthuynganBindingSource.Current == null)
                tbNkthuynganBindingSource.AddNew();
        }

        private void btnInBienBan_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"(*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var outFile = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                string inpFile = System.IO.Path.Combine(Environment.CurrentDirectory, "BBKD.docx");
                FileInfo fileInfo = new FileInfo(inpFile);
                DocumentCore dc = DocumentCore.Load(inpFile);
                dc.Clone(true);
                var modelType = typeof(TbNkthuyngan);
                var properties = modelType.GetProperties().OrderByDescending(p => p.Name.Length);
                foreach (var property in properties)
                {
                    var value = property.GetValue(tbNkthuynganBindingSource.Current);

                    dc.Content.Find($"#{property.Name}").ToList()
                        .ForEach(x =>
                        {
                            x.Replace(value != null ? value.ToString() : "");
                        });
                }

                var dats = dc.Content.Find("#x").ToList();
                var khongDats = dc.Content.Find("#o").ToList();
                var kl = dc.Content.Find("#KL").First();
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan nkthuyngan)
                {
                    bool datTat = true;
                    if (nkthuyngan.Ktbenhngoai.HasValue && nkthuyngan.Ktbenhngoai.Value == 1)
                    {
                        dats[0].Replace("X");
                        khongDats[0].Replace("");
                    }
                    else
                    {
                        datTat = false;
                        dats[0].Replace("");
                        khongDats[0].Replace("X");
                    }
                    if (nkthuyngan.Klqtnhiet.HasValue && nkthuyngan.Klqtnhiet.Value == 1)
                    {
                        dats[1].Replace("X");
                        khongDats[1].Replace("");
                    }
                    else
                    {
                        datTat = false;
                        dats[1].Replace("");
                        khongDats[1].Replace("X");
                    }
                    if (nkthuyngan.Kldoluong.HasValue && nkthuyngan.Kldoluong.Value == 1)
                    {
                        dats[2].Replace("X");
                        khongDats[2].Replace("");
                    }
                    else
                    {
                        datTat = false;
                        dats[2].Replace("");
                        khongDats[2].Replace("X");
                    }
                    if (datTat)
                    {
                        kl.Replace("Đạt yêu cầu kỹ thuật đo lường");
                        dats[3].Replace("X");
                        khongDats[3].Replace("");
                    }
                    else
                    {
                        kl.Replace("Không đạt yêu cầu kỹ thuật đo lường");
                        dats[3].Replace("");
                        khongDats[3].Replace("X");
                    }
                }
                dc.Save(outFile);
                if (MessageBox.Show($"Xuất biên bản hoàn tất.{Environment.NewLine}Bạn có muốn mở tệp không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
                }
            }
        }

        private void btnInGiayKiemDinh_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"(*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var outFile = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                string inpFile = System.IO.Path.Combine(Environment.CurrentDirectory, "CNKD.docx");
                FileInfo fileInfo = new FileInfo(inpFile);
                DocumentCore dc = DocumentCore.Load(inpFile);
                dc.Clone(true);
                var modelType = typeof(TbNkthuyngan);
                var properties = modelType.GetProperties().OrderByDescending(p => p.Name.Length);
                foreach (var property in properties)
                {
                    var value = property.GetValue(tbNkthuynganBindingSource.Current);

                    dc.Content.Find($"#{property.Name}").ToList()
                        .ForEach(x =>
                        {
                            x.Replace(value != null ? value.ToString() : "");
                        });
                }
                DateTime today = DateTime.Today;
                dc.Content.Find("#DateOfIssues").First().Replace($"...., ngày {today.ToString("dd")} tháng {today.ToString("MM")} năm {today.ToString("yyyy")}");
                dc.Save(outFile);
                if (MessageBox.Show($"Xuất giấy chứng nhận hoàn tất.{Environment.NewLine}Bạn có muốn mở tệp không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new TestContext())
            {
                var item = context.TbNkthuyngans.FirstOrDefault(nk => nk.So == txtSearch.Text);
                if (item != null)
                {
                    tbNkthuynganBindingSource.RemoveCurrent();
                    tbNkthuynganBindingSource.Add(item);
                    txtSo.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo");
                }
            }
        }

        float _maxI1;
        float MaxI1
        {
            get => _maxI1; set
            {
                _maxI1 = value;
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    current.Cllnmax = (MaxI2 - MaxI1).ToString();
                }
            }
        }

        float _maxI2;
        float MaxI2
        {
            get => _maxI2; set
            {
                _maxI2 = value;
                if (tbNkthuynganBindingSource.Current is TbNkthuyngan current)
                {
                    current.Cllnmax = (MaxI2 - MaxI1).ToString();
                }
            }
        }

        private void txtMaxI1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtMaxI1.Text, out float MaxI1))
            {
                this.MaxI1 = MaxI1;
            }
        }

        private void txtMaxI2_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtMaxI2.Text, out float MaxI2))
            {
                this.MaxI2 = MaxI2;
            }
        }
    }
}
