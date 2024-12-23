using System.Diagnostics;

namespace Async_SyncForm
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) =>
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            timer.Interval = 1000;
            timer.Start();
        }

        // Senkron Çalýþma
        private void btn_sync_Click(object sender, EventArgs e)
        {
            PrepareScreenForStarting();

            var sw = Stopwatch.StartNew();

            YumurtalariKir();
            YumurtalariCirp();
            TuzEkle();
            OcagiAc();
            TavayiIsit();
            YagiDok();
            YumurtayiEkle();
            Pisir();
            ServisEt();

            sw.Stop();
            AddLog();
            AddLog($"Toplam Yemek Piþirme Süresi: {sw.ElapsedMilliseconds:0} MS");
        }

        // Asenkron Çalýþma
        private async void btn_async_ClickAsync(object sender, EventArgs e)
        {
            PrepareScreenForStarting();

            var sw = Stopwatch.StartNew();

            // Paralel görevler
            var yumurtalariHazirlaTask = Task.Run(async () =>
            {
                await YumurtalariKirAsync();
                await YumurtalariCirpAsync();
                await TuzEkleAsync();
            });

            var ocagiHazirlaTask = Task.Run(async () =>
            {
                await OcagiAcAsync();
                await TavayiIsitAsync();
                await YagiDokAsync();
                await YumurtayiEkleAsync();
            });

            // Tüm görevleri tamamla
            await Task.WhenAll(yumurtalariHazirlaTask, ocagiHazirlaTask);

            // Son iþlemler
            await PisirAsync();
            await ServisEtAsync();

            sw.Stop();
            AddLog();
            AddLog($"Toplam Yemek Piþirme Süresi: {sw.ElapsedMilliseconds:0} MS");
        }

        #region Senkron Metotlar
        public void YumurtalariKir()
        {
            Task.Delay(500).Wait();
            AddLog("Yumurtalar Kýrýldý");
            AdjustButtons(1);
            Application.DoEvents();
        }

        public void YumurtalariCirp()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Çýrpýldý");
            AdjustButtons(2);
            Application.DoEvents();
        }

        public void TuzEkle()
        {
            Task.Delay(200).Wait();
            AddLog("Tuz Eklendi");
            AdjustButtons(3);
            Application.DoEvents();
        }

        public void OcagiAc()
        {
            Task.Delay(500).Wait();
            AddLog("Ocak Açýldý");
            AdjustButtons(4);
            Application.DoEvents();
        }

        public void TavayiIsit()
        {
            Task.Delay(1000).Wait();
            AddLog("Tava Isýndý");
            AdjustButtons(5);
            Application.DoEvents();
        }

        public void YagiDok()
        {
            Task.Delay(750).Wait();
            AddLog("Yað Tavaya Döküldü");
            AdjustButtons(6);
            Application.DoEvents();
        }

        public void YumurtayiEkle()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Tavaya Döküldü");
            AdjustButtons(7);
            Application.DoEvents();
        }

        public void Pisir()
        {
            Task.Delay(2000).Wait();
            AddLog("Yumurtalar Piþti");
            AdjustButtons(8);
            Application.DoEvents();
        }

        public void ServisEt()
        {
            Task.Delay(750).Wait();
            AddLog("Yumurtalar Servis Edildi");
            AdjustButtons(9);
            Application.DoEvents();
        }
        #endregion

        #region Asenkron Metotlar
        public async Task YumurtalariKirAsync()
        {
            await Task.Delay(500);
            AddLog("Yumurtalar Kýrýldý");
            AdjustButtons(1);
        }

        public async Task YumurtalariCirpAsync()
        {
            await Task.Delay(750);
            AddLog("Yumurtalar Çýrpýldý");
            AdjustButtons(2);
        }

        public async Task TuzEkleAsync()
        {
            await Task.Delay(200);
            AddLog("Tuz Eklendi");
            AdjustButtons(3);
        }

        public async Task OcagiAcAsync()
        {
            await Task.Delay(500);
            AddLog("Ocak Açýldý");
            AdjustButtons(4);
        }

        public async Task TavayiIsitAsync()
        {
            await Task.Delay(1000);
            AddLog("Tava Isýndý");
            AdjustButtons(5);
        }

        public async Task YagiDokAsync()
        {
            await Task.Delay(750);
            AddLog("Yað Tavaya Döküldü");
            AdjustButtons(6);
        }

        public async Task YumurtayiEkleAsync()
        {
            await Task.Delay(750);
            AddLog("Yumurtalar Tavaya Döküldü");
            AdjustButtons(7);
        }

        public async Task PisirAsync()
        {
            await Task.Delay(2000);
            AddLog("Yumurtalar Piþti");
            AdjustButtons(8);
        }

        public async Task ServisEtAsync()
        {
            await Task.Delay(750);
            AddLog("Yumurtalar Servis Edildi");
            AdjustButtons(9);
        }
        #endregion

        private void AddLog(string logStr = "")
        {
            if (lst_logbox.InvokeRequired)
            {
                lst_logbox.Invoke(new Action(() => AddLog(logStr)));
            }
            else
            {
                if (!string.IsNullOrEmpty(logStr))
                    logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
                lst_logbox.Items.Add(logStr);
                lst_logbox.TopIndex = lst_logbox.Items.Count - 1;
            }
        }

        private void PrepareScreenForStarting()
        {
            foreach (Control control in pnlButtons.Controls)
            {
                if (control is Button btn)
                    btn.BackColor = SystemColors.Control;
            }

            lst_logbox.Items.Clear();
        }

        private void AdjustButtons(int step)
        {
            if (pnlButtons.InvokeRequired)
            {
                pnlButtons.Invoke(new Action(() => AdjustButtons(step)));
            }
            else
            {
                Button btn = pnlButtons.Controls[$"btnStep{step}"] as Button;

                if (btn != null)
                {
                    btn.BackColor = Color.LimeGreen;
                    btn.Refresh();
                }
            }
        }
    }
}
