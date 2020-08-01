using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
using ComboBox = System.Windows.Controls.ComboBox;

namespace PC_building
{
    public partial class MainWindow : Window
    {
        //Variable
        string cRAM_Buffer = "Ungepuffert";
        string cRAM_ECC = "non ECC";
        string cPSU_Mod = "Unbekannt";
        string Marke = "AMD";
        string MB_Marke = "ASUS";
        string RAM_Speed = "1600";
        string GPU_Marke = "NVIDIA";
        string Case_Marke = "Thermaltake";
        string PSU_Watt = "250";
        string data;
        string OC = "";
        string P_act;
        int a = 0;
        Object selectedItem = null;
        Object selectedItem1 = null;
        Object MBselectedItem1 = null;
        Object RAMselectedItem1 = null;
        Object GPUselectedItem1 = null;
        Object CaseselectedItem1 = null;
        Object PSUselectedItem1 = null;
        Object PselectedItem1 = null;
        Object RselectedItem1 = null;
        Object ATAselectedItem1 = null;
        Object FanselectedItem1 = null;
        Object GPUMselectedItem1 = null;
        Object GselectedItem1 = null;
        Object RAMMselectedItem1 = null;
        Object PumpMselectedItem1 = null;
        Object SaveselectedItem = null;
        String str;
        //Klassen
        Prozessor CPU = new Prozessor();
        Mainboard MB = new Mainboard();
        Arbeitsspeicher RAM = new Arbeitsspeicher();
        Grafikkarte GPU = new Grafikkarte();
        Gehäuse Case = new Gehäuse();
        Netzteil PSU = new Netzteil();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Infos i = new Infos();                //var für Infos Fenster
            i.Show();                             //var Öffnet Fenster
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Help h = new Help();                  //var für Hilfe Fenster
            h.Show();                             //var Öffnet Infos Fenster
        }


        #region Erstellen Tab

        #region CPU Tab

        //CPU Name
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_CPU_Name_.Text;                 //Textbox text zu var Convert übernehmen
            CPU.CpuName = (Convert.ToString());               //var Convert konventieren zu string und zu Eigenschaft übernehmen
        }
        //Kerne
        private void Txt_Kerne__TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Kerne_.Text;
            CPU.CpuCores = (Convert.ToString());
        }
        //Threads
        private void Txt_Threads__TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Threads_.Text;
            CPU.CpuTreads = (Convert.ToString());
        }
        //Marke
        private void Txt_CPU_Marke__TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_CPU_Marke_.Text;
            CPU.CpuMarke = (Convert.ToString());                //Fehler Pfad
        }
        //V-Core
        private void Txt_VCore__TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_VCore_.Text;
            CPU.VCore = (Convert.ToString());
        }
        //Wattage
        private void Txt_CPU_Watt__TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_CPU_Watt_.Text;
            CPU.MaxTDP = (Convert.ToString());
        }
        //Base Clock
        private void Txt_Base_Clock_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Base_Clock.Text;
            CPU.CoreSpeed = (Convert.ToString());
        }
        //Turbo Clock
        private void Txt_Turbo_Clock_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Turbo_Clock.Text;
            CPU.TurboSpeed = (Convert.ToString());
        }
        //Sockel
        private void Txt_Sockel_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Sockel.Text;
            CPU.CpuSockel = (Convert.ToString());
        }
        #endregion

        #region Mainboard Tab

        //Hersteller
        private void Txt_MB_Manuf_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_Manuf.Text;                 //Textbox text zu var Convert übernehmen
            MB.B_Manuf = (Convert.ToString());               //var Convert konventieren zu string und zu Eigenschaft übernehmen
        }
        //Model
        private void Txt_MB_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_Model.Text;
            MB.Model = (Convert.ToString());
        }
        //Formfaktor
        private void Txt_MB_f_Factor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_f_Factor.Text;
            MB.F_factor = (Convert.ToString());
        }
        //Max.RAM
        private void Txt_MB_RAM_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_RAM.Text;
            MB.Max_RAM = (Convert.ToString());
        }
        //Model Nummer
        private void Txt_MB_Model_Num_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_Model_Num.Text;
            MB.Model_Num = (Convert.ToString());
        }
        //CPU Marke
        private void Txt_MB_Marke_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_Sockel.Text;
            MB.CpuM_Support = (Convert.ToString());
        }
        //RAM Typ
        private void Txt_MB_RAM_Typ_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_RAM_Typ.Text;
            MB.RAM_Type = (Convert.ToString());
        }
        //Mainboard Größe
        private void Txt_MB_Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_Size.Text;
            MB.MB_Size = (Convert.ToString());
        }
        //Details
        private void Txt_MB_Details_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_MB_Details.Text;
            MB.Desc = (Convert.ToString());
        }
        #endregion

        #region RAM

        //Hersteller
        private void Txt_RAM_Manuf_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_RAM_Manuf.Text;                 //Textbox text zu var Convert übernehmen
            RAM.RAM_Manuf = (Convert.ToString());             //var Convert konventieren zu string und zu Eigenschaft übernehmen
        }
        //Speed
        private void Txt_RAM_Speed_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_RAM_Speed.Text;
            RAM.MaxB_with = (Convert.ToString());
        }
        //Model Nummer
        private void Txt_RAM_Model_Num_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_RAM_Model_Num.Text;
            RAM.M_Num = (Convert.ToString());
        }
        //Name
        private void Txt_RAM_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_RAM_Name.Text;
            RAM.RAM = (Convert.ToString());
        }
        //Speichergröße
        private void Txt_RAM_Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_RAM_Size.Text;
            RAM.Speicher = (Convert.ToString());
        }
        //Speicher Typ
        private void Txt_RAM_Typus_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_RAM_Typus.Text;
            RAM.RAM_Type = (Convert.ToString());
        }
        //Pufferung
        private void CheckBoxBuffer_Checked(object sender, RoutedEventArgs e)
        {
            cRAM_Buffer = "Gepuffert";
        }

        private void CheckBoxBuffer_Unchecked(object sender, RoutedEventArgs e)
        {
            cRAM_Buffer = "Ungepuffert";
        }
        //ECC
        private void CheckBoxECC_Checked(object sender, RoutedEventArgs e)
        {
            cRAM_ECC = "ECC";
        }
        private void CheckBoxECC_Unchecked(object sender, RoutedEventArgs e)
        {
            cRAM_ECC = "non ECC";
        }

        #endregion

        #region GPU

        //Name
        private void Txt_GPU_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Name.Text;                 //Textbox text zu var Convert übernehmen
            GPU.GpuName = (Convert.ToString());              //var Convert konventieren zu string und zu Eigenschaft übernehmen
        }
        //Marke
        private void Txt_GPU_Marke_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Marke.Text;
            GPU.GpuMarke = (Convert.ToString());
        }
        //Watt
        private void Txt_GPU_Watt_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Watt.Text;
            GPU.GpuWatt = (Convert.ToString());
        }
        //Hersteller
        private void Txt_GPU_Manuf_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Manuf.Text;
            GPU.B_Manuf = (Convert.ToString());
        }
        //Speichergröße
        private void Txt_GPU_Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Size.Text;
            GPU.VRAM = (Convert.ToString());
        }
        //Speicher Typ
        private void Txt_GPU_Typ_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Typ.Text;
            GPU.MemType = (Convert.ToString());
        }
        //Core Clock
        private void Txt_GPU_Core_Clock_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Core_Clock.Text;
            GPU.CoreClock = (Convert.ToString());

        }
        //Boost Clock
        private void Txt_GPU_Boost_Clock_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Boost_Clock.Text;
            GPU.BoostClock = (Convert.ToString());
        }
        //Memory Clock
        private void Txt_GPU_Mem_Clock_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_GPU_Mem_Clock.Text;
            GPU.MemClock = (Convert.ToString());
        }
        #endregion

        #region Case

        //Hersteller
        private void Txt_Case_Manuf_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Manuf.Text;                 //Textbox text zu var Convert übernehmen
            Case.C_Manuf = (Convert.ToString());              //var Convert konventieren zu string und zu Eigenschaft übernehmen
        }
        //Model
        private void Txt_Case_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Model.Text;
            Case.C_Model = (Convert.ToString());
        }
        //Case Typ
        private void Txt_Case_Typ_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Typ.Text;
            Case.C_Type = (Convert.ToString());
        }
        //Model Nummer
        private void Txt_Case_Model_Num_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Model_Num.Text;
            Case.M_Num = (Convert.ToString());
        }
        //Formfaktor
        private void Txt_Case_Ffactor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Ffactor.Text;
            Case.F_factor = (Convert.ToString());
        }
        //Case Größe
        private void Txt_Case_Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Size.Text;
            Case.C_Size = (Convert.ToString());
        }
        //Gewicht
        private void Txt_Case_Weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Weight.Text;
            Case.C_Weight = (Convert.ToString());
        }
        //Lüfter
        private void Txt_Case_Fan_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Fan.Text;
            Case.C_Fan = (Convert.ToString());
        }
        //Details
        private void Txt_Case_Details_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_Case_Details.Text;
            Case.Desc = (Convert.ToString());
        }
        #endregion

        #region PSU

        //Hersteller
        private void Txt_PSU_Manuf_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Manuf.Text;                 //Textbox text zu var Convert übernehmen
            PSU.PsuManuf = (Convert.ToString());              //var Convert konventieren zu string und zu Eigenschaft übernehmen
        }
        //Model
        private void Txt_PSU_Model_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Model.Text;
            PSU.Model = (Convert.ToString());
        }
        //Formfaktor
        private void Txt_PSU_Ffaktor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Ffaktor.Text;
            PSU.F_factor = (Convert.ToString());
        }
        //Model Nummer
        private void Txt_PSU_Model_Num_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Model_Num.Text;
            PSU.M_Num = (Convert.ToString());
        }
        //Größe
        private void Txt_PSU_Size_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Size.Text;
            PSU.Psu_Size = (Convert.ToString());
        }
        //Watt
        private void Txt_PSU_Watt_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Watt.Text;
            PSU.Wattage = (Convert.ToString());
        }
        //Effizienz
        private void Txt_PSU_Effizienz_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Effizienz.Text;
            PSU.Eff = (Convert.ToString());
        }
        //Details
        private void Txt_PSU_Details_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Convert = txt_PSU_Details.Text;
            PSU.Psu_Con = (Convert.ToString());
        }
        //Modular
        private void Nonmod_Checked(object sender, RoutedEventArgs e)       //non Mod
        {
            cPSU_Mod = "non Mod";
        }
        private void HalfMod_Checked(object sender, RoutedEventArgs e)      //Half-Mod
        {
            cPSU_Mod = "Half-Mod";
        }
        private void FullMod_Checked(object sender, RoutedEventArgs e)      //Full-Mod
        {
            cPSU_Mod = "Full-Mod";
        }
        #endregion

        #region Buttons zum Erstellen

        //CPU Tab
        private void CPU_(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PCBuilding/CPU/" + CPU.CpuMarke + "/" + CPU.CpuName);                 //Speicherdatei erstellen .dat
            File.Write(CPU.CpuName + "\r\n" + CPU.CpuMarke + "\r\n" + CPU.CpuCores + "\r\n" + CPU.CpuTreads + "\r\n" + CPU.CpuSockel + "\r\n" + CPU.MaxTDP + "\r\n" + CPU.VCore + "\r\n" + CPU.CoreSpeed + "\r\n" + CPU.TurboSpeed + "\r\n");
            File.Close();
            StreamWriter FileRCP = new StreamWriter("PCBuilding/Readings/CPU/" + CPU.CpuMarke + " " + CPU.CpuName);     //Speicherdatei erstellen .dat zum auslesen
            FileRCP.Write(CPU.CpuName + "\r\n" + CPU.CpuMarke + "\r\n" + CPU.CpuCores + "\r\n" + CPU.CpuTreads + "\r\n" + CPU.CpuSockel + "\r\n" + CPU.MaxTDP + "\r\n" + CPU.VCore + "\r\n" + CPU.CoreSpeed + "\r\n" + CPU.TurboSpeed + "\r\n");
            FileRCP.Close();
        }
        //Mainboard Tab
        private void MB_(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PCBuilding/MB/" + MB.B_Manuf + "/" + MB.CpuM_Support + "/" + MB.Model);
            File.Write(MB.B_Manuf + "\r\n" + MB.Model + "\r\n" + MB.F_factor + "\r\n" + MB.Max_RAM + "\r\n" + MB.Model_Num + "\r\n" + MB.CpuM_Support + "\r\n" + MB.RAM_Type + "\r\n" + MB.MB_Size + "\r\n" + MB.Desc + "\r\n");
            File.Close();
            StreamWriter FileRMB = new StreamWriter("PCBuilding/Readings/MB/" + MB.B_Manuf + " " + MB.CpuM_Support + " " + MB.Model);
            FileRMB.Write(MB.B_Manuf + "\r\n" + MB.Model + "\r\n" + MB.F_factor + "\r\n" + MB.Max_RAM + "\r\n" + MB.Model_Num + "\r\n" + MB.CpuM_Support + "\r\n" + MB.RAM_Type + "\r\n" + MB.MB_Size + "\r\n" + MB.Desc + "\r\n");
            FileRMB.Close();
        }
        //RAM Tab
        private void RAM_(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PCBuilding/RAM/" + RAM.RAM_Type + "/" + RAM.MaxB_with + "/" + RAM.RAM_Manuf + "/" + RAM.RAM);
            File.Write(RAM.RAM_Manuf + "\r\n" + RAM.MaxB_with + "\r\n" + RAM.M_Num + "\r\n" + RAM.RAM + "\r\n" + RAM.RAM_Type + "\r\n" + RAM.Speicher + "\r\n" + RAM.Wattage + "\r\n" + cRAM_Buffer + "\r\n" + cRAM_ECC + "\r\n");
            File.Close();
            StreamWriter FileRR = new StreamWriter("PCBuilding/Readings/RAM/" + RAM.RAM_Type + " " + RAM.MaxB_with + " " + RAM.RAM_Manuf + " " + RAM.RAM);
            FileRR.Write(RAM.RAM_Manuf + "\r\n" + RAM.MaxB_with + "\r\n" + RAM.M_Num + "\r\n" + RAM.RAM + "\r\n" + RAM.RAM_Type + "\r\n" + RAM.Speicher + "\r\n" + RAM.Wattage + "\r\n" + cRAM_Buffer + "\r\n" + cRAM_ECC + "\r\n");
            FileRR.Close();
        }
        //GPU Tab
        private void GPU_(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PCBuilding/GPU/" + GPU.GpuMarke + "/" + GPU.GpuName);
            StreamWriter FileRG = new StreamWriter("PCBuilding/Readings/GPU/" + GPU.GpuMarke + " " + GPU.GpuName);
            File.Write(GPU.GpuName + "\r\n" + GPU.GpuMarke + "\r\n" + GPU.GpuWatt + "\r\n" + GPU.B_Manuf + "\r\n" + GPU.VRAM + "\r\n" + GPU.MemType + "\r\n" + GPU.CoreClock + "\r\n" + GPU.MemClock + "\r\n" + GPU.BoostClock + ".0" + "\r\n");
            File.Close();
            FileRG.Write(GPU.GpuName + "\r\n" + GPU.GpuMarke + "\r\n" + GPU.GpuWatt + "\r\n" + GPU.B_Manuf + "\r\n" + GPU.VRAM + "\r\n" + GPU.MemType + "\r\n" + GPU.CoreClock + "\r\n" + GPU.MemClock + "\r\n" + GPU.BoostClock + "\r\n");
            FileRG.Close();
        }
        //Case Tab
        private void Case_(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PCBuilding/Case/" + Case.C_Manuf + "/" + Case.C_Model);
            StreamWriter FileRC = new StreamWriter("PCBuilding/Readings/Case/" + Case.C_Manuf + " " + Case.C_Model);
            File.Write(Case.C_Model + "\r\n" + Case.C_Manuf + "\r\n" + Case.C_Type + "\r\n" + Case.F_factor + "\r\n" + Case.M_Num + "\r\n" + Case.C_Size + "\r\n" + Case.C_Weight + "\r\n" + Case.C_Fan + "\r\n" + Case.Desc + "\r\n");
            File.Close();
            FileRC.Write(Case.C_Model + "\r\n" + Case.C_Manuf + "\r\n" + Case.C_Type + "\r\n" + Case.F_factor + "\r\n" + Case.M_Num + "\r\n" + Case.C_Size + "\r\n" + Case.C_Weight + "\r\n" + Case.C_Fan + "\r\n" + Case.Desc + "\r\n");
            FileRC.Close();
        }
        //PSU Tab
        private void PSU_(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PCBuilding/PSU/" + PSU.Wattage + "/" + PSU.Model);
            File.Write(PSU.Model + "\r\n" + PSU.PsuManuf + "\r\n" + PSU.F_factor + "\r\n" + PSU.M_Num + "\r\n" + PSU.Psu_Size + "\r\n" + PSU.Wattage + "\r\n" + cPSU_Mod + "\r\n" + PSU.Eff + "\r\n" + PSU.Psu_Con + "\r\n");
            File.Close();
            StreamWriter FileRP = new StreamWriter("PCBuilding/Readings/PSU/" + PSU.Wattage + " " + PSU.Model);
            FileRP.Write(PSU.Model + "\r\n" + PSU.PsuManuf + "\r\n" + PSU.F_factor + "\r\n" + PSU.M_Num + "\r\n" + PSU.Psu_Size + "\r\n" + PSU.Wattage + "\r\n" + cPSU_Mod + "\r\n" + PSU.Eff + "\r\n" + PSU.Psu_Con + "\r\n");
            FileRP.Close();
        }
        #endregion

        #endregion

        #region Auslesen Tab

        #region Profile

        private void APL_Box_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/Profiles");
            foreach (var fi in di.GetFiles())
            {
                var Result = (fi.Name);
                data = Result;
                if (!APL_Box.Items.Contains(data))
                    APL_Box.Items.Add(data);
            }
        }
        private void AP_Bn(object sender, RoutedEventArgs e)
        {
            SaveP_Box.Items.Clear();
            SaveselectedItem = APL_Box.SelectedItem;
            string SaveName = SaveselectedItem.ToString();
            var linesC = File.ReadAllLines(@"PCBuilding/Profiles/" + SaveName);
            string SaveCPU = linesC[0];            //1. Zeile auslesen
            string SaveMB = linesC[1];             //2. Zeile auslesen
            string SaveRAM = linesC[2];            //3. Zeile auslesen
            string SaveGPU = linesC[3];            //4. Zeile auslesen
            string SaveCase = linesC[4];           //5. Zeile auslesen
            string SavePSU = linesC[5];            //6. Zeile auslesen
            string SavePump = linesC[6];           //7. Zeile auslesen
            string SaveOC = linesC[7];             //8. Zeile auslesen
            SaveP_Box.Items.Add(SaveCPU);
            SaveP_Box.Items.Add(SaveMB);
            SaveP_Box.Items.Add(SaveRAM);
            SaveP_Box.Items.Add(SaveGPU);
            SaveP_Box.Items.Add(SaveCase);
            SaveP_Box.Items.Add(SavePSU);
            SaveP_Box.Items.Add(SavePump);
            SaveP_Box.Items.Add(SaveOC);
        }
        #endregion

        #region Komponente

        private void AKLP_Box_Loaded(object sender, RoutedEventArgs e)
        {
            string data = "CPU";
            if (!AKLP_Box.Items.Contains(data))
                AKLP_Box.Items.Add(data);
            string data1 = "MB";
            if (!AKLP_Box.Items.Contains(data1))
                AKLP_Box.Items.Add(data1);
            string data2 = "RAM";
            if (!AKLP_Box.Items.Contains(data2))
                AKLP_Box.Items.Add(data2);
            string data3 = "GPU";
            if (!AKLP_Box.Items.Contains(data3))
                AKLP_Box.Items.Add(data3);
            string data4 = "Case";
            if (!AKLP_Box.Items.Contains(data4))
                AKLP_Box.Items.Add(data4);
            string data5 = "PSU";
            if (!AKLP_Box.Items.Contains(data5))
                AKLP_Box.Items.Add(data5);
        }
        string Komponent = "";
        string Part = "";

        private void AK_Bn(object sender, RoutedEventArgs e)
        {
            SaveK_Box.Items.Clear();

            #region Komponente

            if (Komponent == "CPU"){
                SaveK_Box.Items.Clear();
                SaveselectedItem = AKL_Box.SelectedItem;
                Part = SaveselectedItem.ToString();
                var linesC = File.ReadAllLines(@"PCBuilding/Readings/" + Komponent + "/" + Part);
                
                string CPUName = linesC[0];            //1. Zeile auslesen
                string CPUKerne = linesC[2];           //3. Zeile auslesen
                string CPUThreads = linesC[3];         //4. Zeile auslesen
                string CPUMarke = linesC[1];           //2. Zeile auslesen
                string CPUV_Core = linesC[6];          //7. Zeile auslesen
                string CPUWatt = linesC[5];            //6. Zeile auslesen
                string CPUBase_Clock = linesC[7];      //8. Zeile auslesen
                string CPUTurbo_Clock = linesC[8];     //9. Zeile auslesen
                string CPUSockel = linesC[4];          //5. Zeile auslesen

                SaveK_Box.Items.Add("CPU Name:");
                SaveK_Box.Items.Add(CPUName);
                SaveK_Box.Items.Add("Kerne:");
                SaveK_Box.Items.Add(CPUKerne);
                SaveK_Box.Items.Add("Thread:");
                SaveK_Box.Items.Add(CPUThreads);
                SaveK_Box.Items.Add("CPU Marke:");
                SaveK_Box.Items.Add(CPUMarke);
                SaveK_Box.Items.Add("V-Core:");
                SaveK_Box.Items.Add(CPUV_Core);
                SaveK_Box.Items.Add("Wattage:");
                SaveK_Box.Items.Add(CPUWatt);
                SaveK_Box.Items.Add("Base Clock:");
                SaveK_Box.Items.Add(CPUBase_Clock);
                SaveK_Box.Items.Add("Turbo Clock:");
                SaveK_Box.Items.Add(CPUTurbo_Clock);
                SaveK_Box.Items.Add("Sockel:");
                SaveK_Box.Items.Add(CPUSockel);
            }
            if (Komponent == "MB"){
                SaveK_Box.Items.Clear();
                SaveselectedItem = AKL_Box.SelectedItem;
                Part = SaveselectedItem.ToString();
                var linesC = File.ReadAllLines(@"PCBuilding/Readings/" + Komponent + "/" + Part);

                string MBHersteller = linesC[0];            //1. Zeile auslesen
                string MBModel = linesC[1];                 //2. Zeile auslesen
                string MBFormfaktor = linesC[2];            //3. Zeile auslesen
                string MBMax_Ram = linesC[3];               //4. Zeile auslesen
                string MBModel_Nummer = linesC[4];          //5. Zeile auslesen
                string MBCPU_Sockel = linesC[5];            //6. Zeile auslesen
                string MBRAM_Typ = linesC[6];               //7. Zeile auslesen
                string MBMainboard_Größe = linesC[7];       //8. Zeile auslesen
                string MBDetails = linesC[8];               //9. Zeile auslesen

                SaveK_Box.Items.Add("Hersteller:");
                SaveK_Box.Items.Add(MBHersteller);
                SaveK_Box.Items.Add("Model:");
                SaveK_Box.Items.Add(MBModel);
                SaveK_Box.Items.Add("Formfaktor:");
                SaveK_Box.Items.Add(MBFormfaktor);
                SaveK_Box.Items.Add("Max.RAM:");
                SaveK_Box.Items.Add(MBMax_Ram);
                SaveK_Box.Items.Add("Model Nummer:");
                SaveK_Box.Items.Add(MBModel_Nummer);
                SaveK_Box.Items.Add("CPU Sockel:");
                SaveK_Box.Items.Add(MBCPU_Sockel);
                SaveK_Box.Items.Add("RAM Typ:");
                SaveK_Box.Items.Add(MBRAM_Typ);
                SaveK_Box.Items.Add("Mainboard Größe:");
                SaveK_Box.Items.Add(MBMainboard_Größe);
                SaveK_Box.Items.Add("Details:");
                SaveK_Box.Items.Add(MBDetails);
            }
            if (Komponent == "RAM"){
                SaveselectedItem = AKL_Box.SelectedItem;
                Part = SaveselectedItem.ToString();
                var linesC = File.ReadAllLines(@"PCBuilding/Readings/" + Komponent + "/" + Part);

                string RAMHersteller = linesC[0];              //1. Zeile auslesen
                string RAMSpeed = linesC[1];                   //2. Zeile auslesen
                string RAMModel_Nummer = linesC[2];            //3. Zeile auslesen
                string RAMName = linesC[3];                    //4. Zeile auslesen
                string RAMSpeichergröße = linesC[5];           //6. Zeile auslesen
                string RAMSpeicher_Typ = linesC[4];            //5. Zeile auslesen
                string RAMPufferung = linesC[7];               //8. Zeile auslesen
                string RAM_ECC = linesC[8];                    //9. Zeile auslesen

                SaveK_Box.Items.Add("RAM Hersteller:");
                SaveK_Box.Items.Add(RAMHersteller);
                SaveK_Box.Items.Add("RAM Speed:");
                SaveK_Box.Items.Add(RAMSpeed + "Mhz");
                SaveK_Box.Items.Add("Model Nummer:");
                SaveK_Box.Items.Add(RAMModel_Nummer);
                SaveK_Box.Items.Add("Name:");
                SaveK_Box.Items.Add(RAMName);
                SaveK_Box.Items.Add("Speichergröße:");
                SaveK_Box.Items.Add(RAMSpeichergröße);
                SaveK_Box.Items.Add("Speicher Typ:");
                SaveK_Box.Items.Add(RAMSpeicher_Typ);
                SaveK_Box.Items.Add("Pufferung:");
                SaveK_Box.Items.Add(RAMPufferung);
                SaveK_Box.Items.Add("ECC:");
                SaveK_Box.Items.Add(RAM_ECC);
            }
            if (Komponent == "GPU"){
                SaveK_Box.Items.Clear();
                SaveselectedItem = AKL_Box.SelectedItem;
                Part = SaveselectedItem.ToString();
                var linesC = File.ReadAllLines(@"PCBuilding/Readings/" + Komponent + "/" + Part);

                string GPUName = linesC[0];                       //1. Zeile auslesen
                string GPUMarke = linesC[1];                      //2. Zeile auslesen
                string GPUWatt = linesC[2];                       //3. Zeile auslesen
                string GPUHersteller = linesC[3];                 //4. Zeile auslesen
                string GPUSpeichergröße = linesC[4];              //5. Zeile auslesen
                string GPUSpeicher_Typ = linesC[5];               //6. Zeile auslesen
                string GPUCore_Clock = linesC[6];                 //7. Zeile auslesen
                string GPUBoost_Clock = linesC[7];                //8. Zeile auslesen
                string GPUMemory_Clock = linesC[8];               //9. Zeile auslesen

                SaveK_Box.Items.Add("GPU Name:");
                SaveK_Box.Items.Add(GPUName);
                SaveK_Box.Items.Add("Marke:");
                SaveK_Box.Items.Add(GPUMarke);
                SaveK_Box.Items.Add("Wattage:");
                SaveK_Box.Items.Add(GPUWatt);
                SaveK_Box.Items.Add("Hersteller:");
                SaveK_Box.Items.Add(GPUHersteller);
                SaveK_Box.Items.Add("Speichergröße:");
                SaveK_Box.Items.Add(GPUSpeichergröße + "GB");
                SaveK_Box.Items.Add("Speicher Typ:");
                SaveK_Box.Items.Add(GPUSpeicher_Typ);
                SaveK_Box.Items.Add("Core Clock:");
                SaveK_Box.Items.Add(GPUCore_Clock);
                SaveK_Box.Items.Add("Boost Clock:");
                SaveK_Box.Items.Add(GPUBoost_Clock);
                SaveK_Box.Items.Add("Memory Clock:");
                SaveK_Box.Items.Add(GPUMemory_Clock);
            }
            if (Komponent == "Case"){
                SaveK_Box.Items.Clear();
                SaveselectedItem = AKL_Box.SelectedItem;
                Part = SaveselectedItem.ToString();
                var linesC = File.ReadAllLines(@"PCBuilding/Readings/" + Komponent + "/" + Part);

                string CaseHersteller = linesC[1];                 //1. Zeile auslesen
                string CaseModel = linesC[0];                      //2. Zeile auslesen
                string CaseCase_Typ = linesC[2];                   //3. Zeile auslesen
                string CaseModel_Nummer = linesC[4];               //4. Zeile auslesen
                string CaseFormfaktor = linesC[3];                 //5. Zeile auslesen
                string CaseCase_Größe = linesC[5];                 //6. Zeile auslesen
                string CaseGewicht = linesC[6];                    //7. Zeile auslesen
                string CaseLüfter = linesC[7];                     //8. Zeile auslesen
                string CaseDetails = linesC[8];                    //9. Zeile auslesen

                SaveK_Box.Items.Add("Hersteller:");
                SaveK_Box.Items.Add(CaseHersteller);
                SaveK_Box.Items.Add("Model:");
                SaveK_Box.Items.Add(CaseModel);
                SaveK_Box.Items.Add("Case Typ:");
                SaveK_Box.Items.Add(CaseCase_Typ);
                SaveK_Box.Items.Add("Model Nummer:");
                SaveK_Box.Items.Add(CaseModel_Nummer);
                SaveK_Box.Items.Add("Formfaktor:");
                SaveK_Box.Items.Add(CaseFormfaktor + "GB");
                SaveK_Box.Items.Add("Case Größe:");
                SaveK_Box.Items.Add(CaseCase_Größe);
                SaveK_Box.Items.Add("Gewicht:");
                SaveK_Box.Items.Add(CaseGewicht);
                SaveK_Box.Items.Add("Lüfter:");
                SaveK_Box.Items.Add(CaseLüfter);
                SaveK_Box.Items.Add("Details:");
                SaveK_Box.Items.Add(CaseDetails);
            }
            if (Komponent == "PSU"){
                SaveK_Box.Items.Clear();
                SaveselectedItem = AKL_Box.SelectedItem;
                Part = SaveselectedItem.ToString();
                var linesC = File.ReadAllLines(@"PCBuilding/Readings/" + Komponent + "/" + Part);

                string PSUHersteller = linesC[1];                  //2. Zeile auslesen
                string PSUModel = linesC[0];                       //1. Zeile auslesen
                string PSUFormfaktor = linesC[2];                  //3. Zeile auslesen
                string PSUModel_Nummer = linesC[3];                //4. Zeile auslesen
                string PSUPSU_Größe = linesC[4];                   //5. Zeile auslesen
                string PSUWatt = linesC[5];                        //6. Zeile auslesen
                string PSUMod = linesC[6];                         //7. Zeile auslesen
                string PSUEffizienz = linesC[7];                   //8. Zeile auslesen
                string PSUDetails = linesC[8];                     //9. Zeile auslesen

                SaveK_Box.Items.Add("Hersteller:");
                SaveK_Box.Items.Add(PSUHersteller);
                SaveK_Box.Items.Add("Model:");
                SaveK_Box.Items.Add(PSUModel);
                SaveK_Box.Items.Add("Formfaktor:");
                SaveK_Box.Items.Add(PSUFormfaktor);
                SaveK_Box.Items.Add("Model Nummer:");
                SaveK_Box.Items.Add(PSUModel_Nummer);
                SaveK_Box.Items.Add("PSU Größe:");
                SaveK_Box.Items.Add(PSUPSU_Größe);
                SaveK_Box.Items.Add("Wattage:");
                SaveK_Box.Items.Add(PSUWatt);
                SaveK_Box.Items.Add("Mod:");
                SaveK_Box.Items.Add(PSUMod);
                SaveK_Box.Items.Add("Effizienz:");
                SaveK_Box.Items.Add(PSUEffizienz);
                SaveK_Box.Items.Add("Details:");
                SaveK_Box.Items.Add(PSUDetails);
            }
            #endregion

            selectedItem = AKLP_Box.SelectedItem;
            Komponent = selectedItem.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/Readings/" + Komponent);
            foreach (var fi in di.GetFiles()){
                var Result = (fi.Name);
                data = Result;
                if (!AKL_Box.Items.Contains(data))
                    AKL_Box.Items.Add(data);
            }
        }
        #endregion

        #endregion

        #region Builder Tab

        #region CPU

        //CPU Comboboxen
        public void CPU_MarkeBox_Loaded(object sender, RoutedEventArgs e)
        {
            //CPU Marke
            string data = "Intel";
            if (!CPU_MarkeBox.Items.Contains(data))
                CPU_MarkeBox.Items.Add(data);
            string data_ = "AMD";
            if (!CPU_MarkeBox.Items.Contains(data_))
                CPU_MarkeBox.Items.Add(data_);
        }
        private void CPU_B1_Click(object sender, RoutedEventArgs e)
        {
            //CPU
            CPU_NameBox.Items.Clear();
            selectedItem = CPU_MarkeBox.SelectedItem;
            Marke = selectedItem.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/CPU/" + Marke);
            foreach (var fi in di.GetFiles()){
                var Result = (fi.Name);
                data = Result;
                if (!CPU_NameBox.Items.Contains(data))
                    CPU_NameBox.Items.Add(data);
            }
        }
        #endregion

        #region Mainboard

        //MB Comboboxen
        private void MB_MarkeBox_Loaded(object sender, RoutedEventArgs e)
        {
            //MB Marke
            string data = "ASUS";
            if (!MB_MarkeBox.Items.Contains(data))
                MB_MarkeBox.Items.Add(data);
            string data_ = "Gigabyte";
            if (!MB_MarkeBox.Items.Contains(data_))
                MB_MarkeBox.Items.Add(data_);
        }
        private void MB_B1_Click_1(object sender, RoutedEventArgs e)
        {
            selectedItem1 = CPU_NameBox.SelectedItem;
            CPU.CpuName = selectedItem1.ToString();
            var linesC = File.ReadAllLines(@"PCBuilding/CPU/" + Marke + "/" + CPU.CpuName);
            CPU.CpuSockel = linesC[8];           //7. Zeile Sockel auslesen
            CPU.CpuSockel = "1151";
            //MB
            MB_NameBox.Items.Clear();
            MBselectedItem1 = MB_MarkeBox.SelectedItem;
            MB.B_Manuf = MBselectedItem1.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/MB/" + MB.B_Manuf + "/" + CPU.CpuSockel);
            foreach (var fi in di.GetFiles()){
                var Result = (fi.Name);
                data = Result;
                if (!MB_NameBox.Items.Contains(data))
                    MB_NameBox.Items.Add(data);
            }
        }
        #endregion

        #region RAM

        //RAM Comboboxen

        private void RAM_B2_Click(object sender, RoutedEventArgs e)
        {
            MBselectedItem1 = MB_NameBox.SelectedItem;
            MB.Model = MBselectedItem1.ToString();

            var linesM = File.ReadAllLines(@"PCBuilding/MB/" + MB.B_Manuf + "/" + CPU.CpuSockel + "/" + MB.Model);
            RAM.RAM_Type = linesM[6];           //5. Zeile RAM Typ auslesen

            #region Speeds

            if (RAM.RAM_Type == "DDR4")
            {
                string data = "2133";
                if (!RAM_SpeedBox.Items.Contains(data))
                    RAM_SpeedBox.Items.Add(data);
                string data1 = "2400";
                if (!RAM_SpeedBox.Items.Contains(data1))
                    RAM_SpeedBox.Items.Add(data1);
                string data2 = "2666";
                if (!RAM_SpeedBox.Items.Contains(data2))
                    RAM_SpeedBox.Items.Add(data2);
                string data3 = "2800";
                if (!RAM_SpeedBox.Items.Contains(data3))
                    RAM_SpeedBox.Items.Add(data3);
                string data4 = "3000";
                if (!RAM_SpeedBox.Items.Contains(data4))
                    RAM_SpeedBox.Items.Add(data4);
                string data5 = "3200";
                if (!RAM_SpeedBox.Items.Contains(data5))
                    RAM_SpeedBox.Items.Add(data5);
                string data6 = "3333";
                if (!RAM_SpeedBox.Items.Contains(data6))
                    RAM_SpeedBox.Items.Add(data6);
                string data7 = "3466";
                if (!RAM_SpeedBox.Items.Contains(data7))
                    RAM_SpeedBox.Items.Add(data7);
                string data8 = "3600";
                if (!RAM_SpeedBox.Items.Contains(data8))
                    RAM_SpeedBox.Items.Add(data8);
                string data9 = "3733";
                if (!RAM_SpeedBox.Items.Contains(data9))
                    RAM_SpeedBox.Items.Add(data9);
                string data10 = "3800";
                if (!RAM_SpeedBox.Items.Contains(data10))
                    RAM_SpeedBox.Items.Add(data10);
                string data11 = "3866";
                if (!RAM_SpeedBox.Items.Contains(data11))
                    RAM_SpeedBox.Items.Add(data11);
                string data12 = "4000";
                if (!RAM_SpeedBox.Items.Contains(data12))
                    RAM_SpeedBox.Items.Add(data12);
                string data13 = "4133";
                if (!RAM_SpeedBox.Items.Contains(data13))
                    RAM_SpeedBox.Items.Add(data13);
                string data14 = "4200";
                if (!RAM_SpeedBox.Items.Contains(data14))
                    RAM_SpeedBox.Items.Add(data14);
                string data15 = "4266";
                if (!RAM_SpeedBox.Items.Contains(data15))
                    RAM_SpeedBox.Items.Add(data15);
                string data16 = "4333";
                if (!RAM_SpeedBox.Items.Contains(data16))
                    RAM_SpeedBox.Items.Add(data16);
                string data17 = "4400";
                if (!RAM_SpeedBox.Items.Contains(data17))
                    RAM_SpeedBox.Items.Add(data17);
                string data18 = "4600";
                if (!RAM_SpeedBox.Items.Contains(data18))
                    RAM_SpeedBox.Items.Add(data18);
                string data19 = "4700";
                if (!RAM_SpeedBox.Items.Contains(data19))
                    RAM_SpeedBox.Items.Add(data19);
            }
            if (RAM.RAM_Type == "DDR3")
            {
                string data = "800";
                if (!RAM_SpeedBox.Items.Contains(data))
                    RAM_SpeedBox.Items.Add(data);
                string data1 = "1066";
                if (!RAM_SpeedBox.Items.Contains(data1))
                    RAM_SpeedBox.Items.Add(data1);
                string data2 = "1333";
                if (!RAM_SpeedBox.Items.Contains(data2))
                    RAM_SpeedBox.Items.Add(data2);
                string data3 = "1600";
                if (!RAM_SpeedBox.Items.Contains(data3))
                    RAM_SpeedBox.Items.Add(data3);
                string data4 = "1866";
                if (!RAM_SpeedBox.Items.Contains(data4))
                    RAM_SpeedBox.Items.Add(data4);
                string data5 = "2000";
                if (!RAM_SpeedBox.Items.Contains(data5))
                    RAM_SpeedBox.Items.Add(data5);
                string data6 = "2133";
                if (!RAM_SpeedBox.Items.Contains(data6))
                    RAM_SpeedBox.Items.Add(data6);
                string data7 = "2400";
                if (!RAM_SpeedBox.Items.Contains(data7))
                    RAM_SpeedBox.Items.Add(data7);
                string data8 = "2600";
                if (!RAM_SpeedBox.Items.Contains(data8))
                    RAM_SpeedBox.Items.Add(data8);
                string data9 = "2666";
                if (!RAM_SpeedBox.Items.Contains(data9))
                    RAM_SpeedBox.Items.Add(data9);
                string data10 = "2800";
                if (!RAM_SpeedBox.Items.Contains(data10))
                    RAM_SpeedBox.Items.Add(data10);
                string data11 = "3000";
                if (!RAM_SpeedBox.Items.Contains(data11))
                    RAM_SpeedBox.Items.Add(data11);
                string data12 = "3200";
                if (!RAM_SpeedBox.Items.Contains(data12))
                    RAM_SpeedBox.Items.Add(data12);
            }
            #endregion
        }
        private void RAM_B1_Click_1(object sender, RoutedEventArgs e)
        {
            //RAM
            RAM_NameBox.Items.Clear();
            RAMselectedItem1 = RAM_SpeedBox.SelectedItem;
            RAM_Speed = RAMselectedItem1.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/RAM/" + RAM.RAM_Type + "/" + RAM_Speed);
            foreach (var fi in di.GetFiles()){
                var Result = (fi.Name);
                data = Result;
                if (!RAM_NameBox.Items.Contains(data))
                    RAM_NameBox.Items.Add(data);
            }
        }
        #endregion

        #region GPU

        //GPU Comboboxen
        private void GPU_MarkeBox_Loaded(object sender, RoutedEventArgs e)
        {
            //GPU Marke
            string data = "NVIDIA";
            if (!GPU_MarkeBox.Items.Contains(data))
                GPU_MarkeBox.Items.Add(data);
            string data_ = "AMD";
            if (!GPU_MarkeBox.Items.Contains(data_))
                GPU_MarkeBox.Items.Add(data_);
        }
        private void GPU_MengeBox_Loaded(object sender, RoutedEventArgs e)
        {
            string data = "1";
            if (!GPU_MengeBox.Items.Contains(data))
                GPU_MengeBox.Items.Add(data);
            string data1 = "2";
            if (!GPU_MengeBox.Items.Contains(data1))
                GPU_MengeBox.Items.Add(data1);
            string data2 = "3";
            if (!GPU_MengeBox.Items.Contains(data2))
                GPU_MengeBox.Items.Add(data2);
            string data3 = "4";
            if (!GPU_MengeBox.Items.Contains(data3))
                GPU_MengeBox.Items.Add(data3);
            string data4 = "5";
            if (!GPU_MengeBox.Items.Contains(data4))
                GPU_MengeBox.Items.Add(data4);
            string data5 = "6";
            if (!GPU_MengeBox.Items.Contains(data5))
                GPU_MengeBox.Items.Add(data5);
        }
        private void GPU_B1_Click_1(object sender, RoutedEventArgs e)
        {
            //GPU
            GPU_NameBox.Items.Clear();
            GPUselectedItem1 = GPU_MarkeBox.SelectedItem;
            GPU_Marke = GPUselectedItem1.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/GPU/" + GPU_Marke);
            foreach (var fi in di.GetFiles())
            {
                var Result = (fi.Name);
                data = Result;
                if (!GPU_NameBox.Items.Contains(data))
                    GPU_NameBox.Items.Add(data);
            }
        }
        #endregion
        
        #region Case

        //Case Comboboxen
        private void Case_MarkeBox_Loaded(object sender, RoutedEventArgs e)
        {
            //Case Marke
            string data = "Thermaltake";
            if (!Case_MarkeBox.Items.Contains(data))
                Case_MarkeBox.Items.Add(data);
            string data_ = "Sharkoon";
            if (!Case_MarkeBox.Items.Contains(data_))
                Case_MarkeBox.Items.Add(data_);
        }
        private void Case_B1_Click_1(object sender, RoutedEventArgs e)
        {
            //Case
            Case_NameBox.Items.Clear();
            CaseselectedItem1 = Case_MarkeBox.SelectedItem;
            Case_Marke = CaseselectedItem1.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/Case/" + Case_Marke);
            foreach (var fi in di.GetFiles())
            {
                var Result = (fi.Name);
                data = Result;
                if (!Case_NameBox.Items.Contains(data))
                    Case_NameBox.Items.Add(data);
            }
        }
        #endregion

        #region PSU

        #region PSU WattBox

        //PSU Comboboxen
        private void PSU_WattBox_Loaded(object sender, RoutedEventArgs e)
        {
            //PSU Marke
            string data = "250W";
            if (!PSU_WattBox.Items.Contains(data))
                PSU_WattBox.Items.Add(data);
            string data1 = "300W";
            if (!PSU_WattBox.Items.Contains(data1))
                PSU_WattBox.Items.Add(data1);
            string data2 = "350W";
            if (!PSU_WattBox.Items.Contains(data2))
                PSU_WattBox.Items.Add(data2);
            string data3 = "400W";
            if (!PSU_WattBox.Items.Contains(data3))
                PSU_WattBox.Items.Add(data3);
            string data4 = "430W";
            if (!PSU_WattBox.Items.Contains(data4))
                PSU_WattBox.Items.Add(data4);
            string data5 = "450W";
            if (!PSU_WattBox.Items.Contains(data5))
                PSU_WattBox.Items.Add(data5);
            string data6 = "500W";
            if (!PSU_WattBox.Items.Contains(data6))
                PSU_WattBox.Items.Add(data6);
            string data7 = "530W";
            if (!PSU_WattBox.Items.Contains(data7))
                PSU_WattBox.Items.Add(data7);
            string data8 = "550W";
            if (!PSU_WattBox.Items.Contains(data8))
                PSU_WattBox.Items.Add(data8);
            string data9 = "600W";
            if (!PSU_WattBox.Items.Contains(data9))
                PSU_WattBox.Items.Add(data9);
            string data10 = "630W";
            if (!PSU_WattBox.Items.Contains(data10))
                PSU_WattBox.Items.Add(data10);
            string data11 = "650W";
            if (!PSU_WattBox.Items.Contains(data11))
                PSU_WattBox.Items.Add(data11);
            string data12 = "700W";
            if (!PSU_WattBox.Items.Contains(data12))
                PSU_WattBox.Items.Add(data12);
            string data13 = "730W";
            if (!PSU_WattBox.Items.Contains(data13))
                PSU_WattBox.Items.Add(data13);
            string data14 = "750W";
            if (!PSU_WattBox.Items.Contains(data14))
                PSU_WattBox.Items.Add(data14);
            string data15 = "800W";
            if (!PSU_WattBox.Items.Contains(data15))
                PSU_WattBox.Items.Add(data15);
            string data16 = "830W";
            if (!PSU_WattBox.Items.Contains(data16))
                PSU_WattBox.Items.Add(data16);
            string data17 = "850W";
            if (!PSU_WattBox.Items.Contains(data17))
                PSU_WattBox.Items.Add(data17);
        }
        #endregion

        private void PSU_B1_Click_1(object sender, RoutedEventArgs e)
        {
            //PSU
            PSU_NameBox.Items.Clear();
            PSUselectedItem1 = PSU_WattBox.SelectedItem;
            PSU_Watt = PSUselectedItem1.ToString();
            DirectoryInfo di = new DirectoryInfo(@"PCBuilding/PSU/" + PSU_Watt);
            foreach (var fi in di.GetFiles()){
                var Result = (fi.Name);
                data = Result;
                if (!PSU_NameBox.Items.Contains(data))
                    PSU_NameBox.Items.Add(data);
            }
        }
        #endregion

        #region RAM Menge

        private void RAM_MengeBox_Loaded(object sender, RoutedEventArgs e)
        {
            string data = "1";
            if (!RAM_MengeBox.Items.Contains(data))
                RAM_MengeBox.Items.Add(data);
            string data1 = "2";
            if (!RAM_MengeBox.Items.Contains(data1))
                RAM_MengeBox.Items.Add(data1);
            string data2 = "3";
            if (!RAM_MengeBox.Items.Contains(data2))
                RAM_MengeBox.Items.Add(data2);
            string data3 = "4";
            if (!RAM_MengeBox.Items.Contains(data3))
                RAM_MengeBox.Items.Add(data3);
            string data4 = "5";
            if (!RAM_MengeBox.Items.Contains(data4))
                RAM_MengeBox.Items.Add(data4);
            string data5 = "6";
            if (!RAM_MengeBox.Items.Contains(data5))
                RAM_MengeBox.Items.Add(data5);
            string data6 = "7";
            if (!RAM_MengeBox.Items.Contains(data6))
                RAM_MengeBox.Items.Add(data6);
            string data7 = "8";
            if (!RAM_MengeBox.Items.Contains(data7))
                RAM_MengeBox.Items.Add(data7);
            string data8 = "9";
            if (!RAM_MengeBox.Items.Contains(data8))
                RAM_MengeBox.Items.Add(data8);
            string data9 = "10";
            if (!RAM_MengeBox.Items.Contains(data9))
                RAM_MengeBox.Items.Add(data9);
            string data10 = "11";
            if (!RAM_MengeBox.Items.Contains(data10))
                RAM_MengeBox.Items.Add(data10);
            string data11 = "12";
            if (!RAM_MengeBox.Items.Contains(data11))
                RAM_MengeBox.Items.Add(data11);
            string data12 = "13";
            if (!RAM_MengeBox.Items.Contains(data12))
                RAM_MengeBox.Items.Add(data12);
            string data13 = "14";
            if (!RAM_MengeBox.Items.Contains(data13))
                RAM_MengeBox.Items.Add(data13);
            string data14 = "15";
            if (!RAM_MengeBox.Items.Contains(data14))
                RAM_MengeBox.Items.Add(data14);
            string data15 = "16";
            if (!RAM_MengeBox.Items.Contains(data15))
                RAM_MengeBox.Items.Add(data15);
            string data16 = "17";
            if (!RAM_MengeBox.Items.Contains(data16))
                RAM_MengeBox.Items.Add(data16);
            string data17 = "18";
            if (!RAM_MengeBox.Items.Contains(data17))
                RAM_MengeBox.Items.Add(data17);
            string data18 = "19";
            if (!RAM_MengeBox.Items.Contains(data18))
                RAM_MengeBox.Items.Add(data18);
            string data19 = "20";
            if (!RAM_MengeBox.Items.Contains(data19))
                RAM_MengeBox.Items.Add(data19);
        }
        #endregion

        #region ATA Menge

        private void ATA_MengeBox_Loaded(object sender, RoutedEventArgs e)
        {
            string data = "1";
            if (!ATA_MengeBox.Items.Contains(data))
                ATA_MengeBox.Items.Add(data);
            string data1 = "2";
            if (!ATA_MengeBox.Items.Contains(data1))
                ATA_MengeBox.Items.Add(data1);
            string data2 = "3";
            if (!ATA_MengeBox.Items.Contains(data2))
                ATA_MengeBox.Items.Add(data2);
            string data3 = "4";
            if (!ATA_MengeBox.Items.Contains(data3))
                ATA_MengeBox.Items.Add(data3);
            string data4 = "5";
            if (!ATA_MengeBox.Items.Contains(data4))
                ATA_MengeBox.Items.Add(data4);
            string data5 = "6";
            if (!ATA_MengeBox.Items.Contains(data5))
                ATA_MengeBox.Items.Add(data5);
            string data6 = "7";
            if (!ATA_MengeBox.Items.Contains(data6))
                ATA_MengeBox.Items.Add(data6);
            string data7 = "8";
            if (!ATA_MengeBox.Items.Contains(data7))
                ATA_MengeBox.Items.Add(data7);
            string data8 = "9";
            if (!ATA_MengeBox.Items.Contains(data8))
                ATA_MengeBox.Items.Add(data8);
            string data9 = "10";
            if (!ATA_MengeBox.Items.Contains(data9))
                ATA_MengeBox.Items.Add(data9);
            string data10 = "11";
            if (!ATA_MengeBox.Items.Contains(data10))
                ATA_MengeBox.Items.Add(data10);
            string data11 = "12";
            if (!ATA_MengeBox.Items.Contains(data11))
                ATA_MengeBox.Items.Add(data11);
            string data12 = "13";
            if (!ATA_MengeBox.Items.Contains(data12))
                ATA_MengeBox.Items.Add(data12);
            string data13 = "14";
            if (!ATA_MengeBox.Items.Contains(data13))
                ATA_MengeBox.Items.Add(data13);
            string data14 = "15";
            if (!ATA_MengeBox.Items.Contains(data14))
                ATA_MengeBox.Items.Add(data14);
            string data15 = "16";
            if (!ATA_MengeBox.Items.Contains(data15))
                ATA_MengeBox.Items.Add(data15);
            string data16 = "17";
            if (!ATA_MengeBox.Items.Contains(data16))
                ATA_MengeBox.Items.Add(data16);
            string data17 = "18";
            if (!ATA_MengeBox.Items.Contains(data17))
                ATA_MengeBox.Items.Add(data17);
            string data18 = "19";
            if (!ATA_MengeBox.Items.Contains(data18))
                ATA_MengeBox.Items.Add(data18);
            string data19 = "20";
            if (!ATA_MengeBox.Items.Contains(data19))
                ATA_MengeBox.Items.Add(data19);

        }

        #endregion

        #region Fan Menge

        private void Fan_MengeBox_Loaded(object sender, RoutedEventArgs e)
        {
            string data = "1";
            if (!Fan_MengeBox.Items.Contains(data))
                Fan_MengeBox.Items.Add(data);
            string data1 = "2";
            if (!Fan_MengeBox.Items.Contains(data1))
                Fan_MengeBox.Items.Add(data1);
            string data2 = "3";
            if (!Fan_MengeBox.Items.Contains(data2))
                Fan_MengeBox.Items.Add(data2);
            string data3 = "4";
            if (!Fan_MengeBox.Items.Contains(data3))
                Fan_MengeBox.Items.Add(data3);
            string data4 = "5";
            if (!Fan_MengeBox.Items.Contains(data4))
                Fan_MengeBox.Items.Add(data4);
            string data5 = "6";
            if (!Fan_MengeBox.Items.Contains(data5))
                Fan_MengeBox.Items.Add(data5);
            string data6 = "7";
            if (!Fan_MengeBox.Items.Contains(data6))
                Fan_MengeBox.Items.Add(data6);
            string data7 = "8";
            if (!Fan_MengeBox.Items.Contains(data7))
                Fan_MengeBox.Items.Add(data7);
            string data8 = "9";
            if (!Fan_MengeBox.Items.Contains(data8))
                Fan_MengeBox.Items.Add(data8);
            string data9 = "10";
            if (!Fan_MengeBox.Items.Contains(data9))
                Fan_MengeBox.Items.Add(data9);
            string data10 = "11";
            if (!Fan_MengeBox.Items.Contains(data10))
                Fan_MengeBox.Items.Add(data10);
            string data11 = "12";
            if (!Fan_MengeBox.Items.Contains(data11))
                Fan_MengeBox.Items.Add(data11);
            string data12 = "13";
            if (!Fan_MengeBox.Items.Contains(data12))
                Fan_MengeBox.Items.Add(data12);
            string data13 = "14";
            if (!Fan_MengeBox.Items.Contains(data13))
                Fan_MengeBox.Items.Add(data13);
            string data14 = "15";
            if (!Fan_MengeBox.Items.Contains(data14))
                Fan_MengeBox.Items.Add(data14);
            string data15 = "16";
            if (!Fan_MengeBox.Items.Contains(data15))
                Fan_MengeBox.Items.Add(data15);
            string data16 = "17";
            if (!Fan_MengeBox.Items.Contains(data16))
                Fan_MengeBox.Items.Add(data16);
            string data17 = "18";
            if (!Fan_MengeBox.Items.Contains(data17))
                Fan_MengeBox.Items.Add(data17);
            string data18 = "19";
            if (!Fan_MengeBox.Items.Contains(data18))
                Fan_MengeBox.Items.Add(data18);
            string data19 = "20";
            if (!Fan_MengeBox.Items.Contains(data19))
                Fan_MengeBox.Items.Add(data19);
        }
        #endregion

        #region Pumpen [Aktivierung]

        //Pumpen Aktivierung
        private void Pump_EnableBox_Checked(object sender, RoutedEventArgs e)
        {
            Pump_MengeBox.IsEnabled = true;
        }
        private void Pump_EnableBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Pump_MengeBox.IsEnabled = false;
        }

        #region Pumpen Menge

        private void Pump_MengeBox_Loaded(object sender, RoutedEventArgs e)
        {
            string data = "1";
            if (!Fan_MengeBox.Items.Contains(data))
                Fan_MengeBox.Items.Add(data);
            string data1 = "2";
            if (!Fan_MengeBox.Items.Contains(data1))
                Fan_MengeBox.Items.Add(data1);
            string data2 = "3";
            if (!Fan_MengeBox.Items.Contains(data2))
                Fan_MengeBox.Items.Add(data2);
            string data3 = "4";
            if (!Fan_MengeBox.Items.Contains(data3))
                Fan_MengeBox.Items.Add(data3);
            string data4 = "5";
            if (!Fan_MengeBox.Items.Contains(data4))
                Fan_MengeBox.Items.Add(data4);
            string data5 = "6";
            if (!Fan_MengeBox.Items.Contains(data5))
                Fan_MengeBox.Items.Add(data5);
            string data6 = "7";
            if (!Fan_MengeBox.Items.Contains(data6))
                Fan_MengeBox.Items.Add(data6);
            string data7 = "8";
            if (!Fan_MengeBox.Items.Contains(data7))
                Fan_MengeBox.Items.Add(data7);
            string data8 = "9";
            if (!Fan_MengeBox.Items.Contains(data8))
                Fan_MengeBox.Items.Add(data8);
            string data9 = "10";
            if (!Fan_MengeBox.Items.Contains(data9))
                Fan_MengeBox.Items.Add(data9);
            string data10 = "11";
            if (!Fan_MengeBox.Items.Contains(data10))
                Fan_MengeBox.Items.Add(data10);
            string data11 = "12";
            if (!Fan_MengeBox.Items.Contains(data11))
                Fan_MengeBox.Items.Add(data11);
            string data12 = "13";
            if (!Fan_MengeBox.Items.Contains(data12))
                Fan_MengeBox.Items.Add(data12);
            string data13 = "14";
            if (!Fan_MengeBox.Items.Contains(data13))
                Fan_MengeBox.Items.Add(data13);
            string data14 = "15";
            if (!Fan_MengeBox.Items.Contains(data14))
                Fan_MengeBox.Items.Add(data14);
            string data15 = "16";
            if (!Fan_MengeBox.Items.Contains(data15))
                Fan_MengeBox.Items.Add(data15);
            string data16 = "17";
            if (!Fan_MengeBox.Items.Contains(data16))
                Fan_MengeBox.Items.Add(data16);
            string data17 = "18";
            if (!Fan_MengeBox.Items.Contains(data17))
                Fan_MengeBox.Items.Add(data17);
            string data18 = "19";
            if (!Fan_MengeBox.Items.Contains(data18))
                Fan_MengeBox.Items.Add(data18);
            string data19 = "20";
            if (!Fan_MengeBox.Items.Contains(data19))
                Fan_MengeBox.Items.Add(data19);
        }
        #endregion

        #endregion

        #region Watt Rechner

        private void Cal_Click(object sender, RoutedEventArgs e)
        {
            CaseselectedItem1 = Case_NameBox.SelectedItem;
            string CaseN = CaseselectedItem1.ToString();

            GPUselectedItem1 = GPU_NameBox.SelectedItem;
            GPU.GpuName = GPUselectedItem1.ToString();

            RAMselectedItem1 = RAM_NameBox.SelectedItem;
            string RAMN = RAMselectedItem1.ToString();

            //Variablen
            string P_Watt = "";
            int RAM_Slots = 0;
            //CPU
            var linesC = File.ReadAllLines(@"PCBuilding/CPU/" + Marke + "/" + CPU.CpuName);
            var C_Sockel = linesC[8];           //7. Zeile Sockel auslesen
            var CPU_Builder = linesC[6];           //5. Zeile Name auslesen
            var CPU_Watt = linesC[5];           //4. Zeile Watt auslesen
            var CPU_Speed = linesC[10];           //11. Zeile lesen
            //GPU
            var linesG = File.ReadAllLines(@"PCBuilding/GPU/" + GPU_Marke + "/" + GPU.GpuName);
            var GPU_Watt = linesG[2];           //3. Zeile TDP auslesen
            var GPU_Builder = linesG[0];           //1. Zeile Name auslesen
            var GPU_Speed = linesG[7];           //6. Zeile Boost Clock auslesen
            //Mainboard
            var linesM = File.ReadAllLines(@"PCBuilding/MB/" + MB.B_Manuf + "/" + CPU.CpuSockel + "/" + MB.Model);
            var M_RAM = linesM[6];           //5. Zeile RAM Typ auslesen
            //Converter
            int.TryParse(CPU_Watt, out int CPU_TWatt);
            int.TryParse(CPU_Speed, out int CPU_TSpeed);
            double.TryParse(GPU_Speed, out double GPU_TSpeed);
            double.TryParse(GPU_Watt, out double GPU_TWatt);
            double.TryParse(P_Watt, out double P_TWatt);
            //RAM Menge
            RselectedItem1 = RAM_MengeBox.SelectedItem;         //Inhalt von ComboBox in Objekt übertragen
            string Convert2 = RselectedItem1.ToString();        //Inhalt von Objekt konvertiert zu string und in var Convert übertragen
            int.TryParse(Convert2, out int RAM_Menge);          //Inhalt von 'string Convert' konventiert in integer und in erstellten integer /..._Menge übertragen
            //ATA Menge
            ATAselectedItem1 = ATA_MengeBox.SelectedItem;
            string Convert3 = ATAselectedItem1.ToString();
            int.TryParse(Convert3, out int Sata_Menge);
            //Lüfter Menge
            FanselectedItem1 = Fan_MengeBox.SelectedItem;
            string Convert4 = FanselectedItem1.ToString();
            int.TryParse(Convert4, out int Fan_Menge);
            //GPU Menge
            GselectedItem1 = GPU_MengeBox.SelectedItem;
            string Convert5 = GselectedItem1.ToString();
            int.TryParse(Convert5, out int GPU_Menge);
            //RAM, S-ATA/P-ATA, Lüfter Rechner
            P_TWatt = (RAM_Menge * 5) + (Sata_Menge * 15) + (Fan_Menge * 5);
            //pumpen
            if (Pump_MengeBox.IsEnabled == true) {
                PselectedItem1 = Pump_MengeBox.SelectedItem;
                string Convert1 = PselectedItem1.ToString();
                int.TryParse(Convert1, out int P_Menge);
                P_TWatt = P_TWatt + (P_Menge * 10);
            }
            //Übertaktungsrechner Checkbox
            if (HW_OC_EnableBox.IsChecked == true){
                GPU_TWatt = GPU_Menge * GPU_TWatt;
                P_TWatt = P_TWatt + (GPU_TWatt * ((GPU_TSpeed / 100) * 110) / GPU_TSpeed);
                P_TWatt = P_TWatt + (CPU_TWatt * ((CPU_TSpeed / 100) * 130) / CPU_TSpeed);
            }
            else{
                P_TWatt = P_TWatt + CPU_TWatt;
                GPU_TWatt = GPU_Menge * GPU_TWatt;
                P_TWatt = P_TWatt + GPU_TWatt;
            }
            string PT_TWatt = P_TWatt.ToString();
            Wattzahl_TextBox.Text = PT_TWatt;
        }
        #endregion

        #region Speichern

        private void Save_B1_Click_1(object sender, RoutedEventArgs e)
        {
            PSUselectedItem1 = PSU_NameBox.SelectedItem;
            string PSUN = PSUselectedItem1.ToString();

            CaseselectedItem1 = Case_NameBox.SelectedItem;
            string CaseN = CaseselectedItem1.ToString();

            GPUselectedItem1 = GPU_NameBox.SelectedItem;
            GPU.GpuName = GPUselectedItem1.ToString();

            RAMselectedItem1 = RAM_NameBox.SelectedItem;
            string RAMN = RAMselectedItem1.ToString();

            selectedItem1 = CPU_NameBox.SelectedItem;
            CPU.CpuName = selectedItem1.ToString();

            MBselectedItem1 = MB_NameBox.SelectedItem;
            MB.Model = MBselectedItem1.ToString();

            GPUMselectedItem1 = GPU_MengeBox.SelectedItem;
            string GPU_M = GPUMselectedItem1.ToString();

            RAMMselectedItem1 = RAM_MengeBox.SelectedItem;
            string RAM_M = RAMMselectedItem1.ToString();
            string Pump_M;
            if (Pump_MengeBox.IsEnabled == true){
                PumpMselectedItem1 = Pump_MengeBox.SelectedItem;
                Pump_M = PumpMselectedItem1.ToString();
                P_act = " Ja";
            }
            else {
                P_act = " Nein";
                Pump_M = "0";

            }
            if (HW_OC_EnableBox.IsChecked == true){
                OC = "Overclocked";
            }
            else {
                OC = "Stock";
            }
            string SP_Name = txt_SP.Text;
            //Speichern
            StreamWriter File = new StreamWriter("PCBuilding/Profiles/" + SP_Name);                 //Speicherdatei erstellen .dat
            File.Write("Prozessor:\t" + CPU.CpuName + "\r\n" + "Mainboard:\t" + MB.Model + "\r\n" + "Arbeitsspeicher:\t" + RAMN + " " + RAM_M + "x" + RAM_Speed + "Mhz" + "\r\n" + "Grafikkarte:\t" + GPU.GpuName + " " + GPU_M + "x" + "\r\n" + "Gehäuse:\t" + CaseN + "\r\n" + "Netzteil:\t\t" + PSUN + " " + PSU_Watt + "\r\n" + "Wakü Unterstützung" + P_act + " " + Pump_M + "x" + "\r\n" + OC + "\r\n");
            File.Close();
        }
        #endregion

        #endregion

        #region Dark Mode

        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            if (a == 1){
                TabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                ETabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EETabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EECTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EERAMTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EEMBTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EEGTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EECaseTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                EEPTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                CPU_B.Foreground = Brushes.Black;
                CPU_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                CPU_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                MB_B.Foreground = Brushes.Black;
                MB_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                MB_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                RAM_B.Foreground = Brushes.Black;
                RAM_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                RAM_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                GPU_B.Foreground = Brushes.Black;
                GPU_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                GPU_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                Case_B.Foreground = Brushes.Black;
                Case_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                Case_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                PSU_B.Foreground = Brushes.Black;
                PSU_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                PSU_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                MBH.Foreground = Brushes.Black;
                MBM.Foreground = Brushes.Black;
                MBF.Foreground = Brushes.Black;
                MRAM.Foreground = Brushes.Black;
                MN.Foreground = Brushes.Black;
                CS.Foreground = Brushes.Black;
                RAMT.Foreground = Brushes.Black;
                MG.Foreground = Brushes.Black;
                Des.Foreground = Brushes.Black;
                RH.Foreground = Brushes.Black;
                RS.Foreground = Brushes.Black;
                RMN.Foreground = Brushes.Black;
                RM.Foreground = Brushes.Black;
                SG.Foreground = Brushes.Black;
                ST.Foreground = Brushes.Black;
                PF.Foreground = Brushes.Black;
                ECC.Foreground = Brushes.Black;
                GN.Foreground = Brushes.Black;
                GM.Foreground = Brushes.Black;
                GW.Foreground = Brushes.Black;
                GH.Foreground = Brushes.Black;
                GS.Foreground = Brushes.Black;
                GST.Foreground = Brushes.Black;
                GCC.Foreground = Brushes.Black;
                GBC.Foreground = Brushes.Black;
                GMC.Foreground = Brushes.Black;
                CH.Foreground = Brushes.Black;
                CM.Foreground = Brushes.Black;
                CCT.Foreground = Brushes.Black;
                CMN.Foreground = Brushes.Black;
                CFF.Foreground = Brushes.Black;
                CG.Foreground = Brushes.Black;
                CG1.Foreground = Brushes.Black;
                CL.Foreground = Brushes.Black;
                Desu.Foreground = Brushes.Black;
                PH.Foreground = Brushes.Black;
                PM.Foreground = Brushes.Black;
                PFF.Foreground = Brushes.Black;
                PMN.Foreground = Brushes.Black;
                PPG.Foreground = Brushes.Black;
                PW.Foreground = Brushes.Black;
                PEFF.Foreground = Brushes.Black;
                Des_.Foreground = Brushes.Black;
                nMd.Foreground = Brushes.Black;
                HM.Foreground = Brushes.Black;
                FM.Foreground = Brushes.Black;
                LC_Marke.Foreground = Brushes.Black;
                L_CPU.Foreground = Brushes.Black;
                MBC_Marke.Foreground = Brushes.Black;
                MB_C.Foreground = Brushes.Black;
                RAMC_Speed.Foreground = Brushes.Black;
                RAM_C.Foreground = Brushes.Black;
                LG_Marke.Foreground = Brushes.Black;
                L_GPU.Foreground = Brushes.Black;
                LCase_Marke.Foreground = Brushes.Black;
                L_Case.Foreground = Brushes.Black;
                LRAM_Menge.Foreground = Brushes.Black;
                L_ATA_Menge.Foreground = Brushes.Black;
                WaküC.Foreground = Brushes.Black;
                LFAN.Foreground = Brushes.Black;
                LP.Foreground = Brushes.Black;
                HW_OCL.Foreground = Brushes.Black;
                PSU_L.Foreground = Brushes.Black;
                PSL.Foreground = Brushes.Black;
                Save1L.Foreground = Brushes.Black;
                Save2L.Foreground = Brushes.Black;
                Save3L.Stroke = Brushes.Black;
                Watt1L.Foreground = (Brush)bc.ConvertFrom("#FFFF4F4F");
                Watt2L.Foreground = (Brush)bc.ConvertFrom("#FFFF4F4F");
                Watt3L.Foreground = (Brush)bc.ConvertFrom("#FFFF4F4F");
                RAM_B2.Foreground = Brushes.Black;
                RAM_B2.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                RAM_B2.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                RAM_B1.Foreground = Brushes.Black;
                RAM_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                RAM_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                MB_B1.Foreground = Brushes.Black;
                MB_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                MB_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                CPU_B1.Foreground = Brushes.Black;
                CPU_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                CPU_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                GPU_B1.Foreground = Brushes.Black;
                GPU_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                GPU_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                Case_B1.Foreground = Brushes.Black;
                Case_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                Case_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                PSU_B1.Foreground = Brushes.Black;
                PSU_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                PSU_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                Save_B1.Foreground = Brushes.Black;
                Save_B1.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                Save_B1.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                Cal.Foreground = Brushes.Black;
                Cal.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                Cal.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                Win1C.Background = Brushes.White;
                BT_C.Foreground = Brushes.Black;
                BT_C.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                AT_C.Foreground = Brushes.Black;
                AT_C.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                ET_C.Foreground = Brushes.Black;
                ET_C.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                CTabColor.Foreground = Brushes.Black;
                CTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                RAMTabColor.Foreground = Brushes.Black;
                RAMTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                MBTabColor.Foreground = Brushes.Black;
                MBTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                GPUTabColor.Foreground = Brushes.Black;
                GPUTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                CaseTabColor.Foreground = Brushes.Black;
                CaseTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                PSUTabColor.Foreground = Brushes.Black;
                PSUTabColor.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                AP_Tab.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                ATab.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                PName.Foreground = Brushes.Black;
                CCPUN.Foreground = Brushes.Black;
                CCPUK.Foreground = Brushes.Black;
                CCPUT.Foreground = Brushes.Black;
                CCPUM.Foreground = Brushes.Black;
                CCPUV.Foreground = Brushes.Black;
                CCPUW.Foreground = Brushes.Black;
                CCPUB.Foreground = Brushes.Black;
                CCPUC.Foreground = Brushes.Black;
                CCPUS.Foreground = Brushes.Black;
                APT_Tab.Foreground = Brushes.Black;
                APT_Tab.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                AKT_Tab.Foreground = Brushes.Black;
                AKT_Tab.Background = (Brush)bc.ConvertFrom("#FFE5E5E5");
                SaveP_Box.Background = Brushes.White;
                SaveP_Box.Foreground = Brushes.Black;
                SaveK_Box.Background = Brushes.White;
                SaveK_Box.Foreground = Brushes.Black;
                AK_B.Foreground = Brushes.Black;
                AK_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                AK_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                AP_B.Foreground = Brushes.Black;
                AP_B.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
                AP_B.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");

                a = 0;
            }
            else{
                TabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                ETabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EETabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EECTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EEMBTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EERAMTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EEGTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EECaseTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                EEPTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                LC_Marke.Foreground = Brushes.White;
                L_CPU.Foreground = Brushes.White;
                MBC_Marke.Foreground = Brushes.White;
                MB_C.Foreground = Brushes.White;
                RAMC_Speed.Foreground = Brushes.White;
                RAM_C.Foreground = Brushes.White;
                LG_Marke.Foreground = Brushes.White;
                L_GPU.Foreground = Brushes.White;
                LCase_Marke.Foreground = Brushes.White;
                L_Case.Foreground = Brushes.White;
                CCPUN.Foreground = Brushes.White;
                CCPUK.Foreground = Brushes.White;
                CCPUT.Foreground = Brushes.White;
                CCPUM.Foreground = Brushes.White;
                CCPUV.Foreground = Brushes.White;
                CCPUW.Foreground = Brushes.White;
                CCPUB.Foreground = Brushes.White;
                CCPUC.Foreground = Brushes.White;
                CCPUS.Foreground = Brushes.White;
                MBH.Foreground = Brushes.White;
                MBM.Foreground = Brushes.White;
                MBF.Foreground = Brushes.White;
                MRAM.Foreground = Brushes.White;
                MN.Foreground = Brushes.White;
                CS.Foreground = Brushes.White;
                RAMT.Foreground = Brushes.White;
                MG.Foreground = Brushes.White;
                Des.Foreground = Brushes.White;
                RH.Foreground = Brushes.White;
                RS.Foreground = Brushes.White;
                RMN.Foreground = Brushes.White;
                RM.Foreground = Brushes.White;
                SG.Foreground = Brushes.White;
                ST.Foreground = Brushes.White;
                PF.Foreground = Brushes.White;
                ECC.Foreground = Brushes.White;
                GN.Foreground = Brushes.White;
                GM.Foreground = Brushes.White;
                GW.Foreground = Brushes.White;
                GH.Foreground = Brushes.White;
                GS.Foreground = Brushes.White;
                GST.Foreground = Brushes.White;
                GCC.Foreground = Brushes.White;
                GBC.Foreground = Brushes.White;
                GMC.Foreground = Brushes.White;
                CH.Foreground = Brushes.White;
                CM.Foreground = Brushes.White;
                CCT.Foreground = Brushes.White;
                CMN.Foreground = Brushes.White;
                CFF.Foreground = Brushes.White;
                CG.Foreground = Brushes.White;
                CG1.Foreground = Brushes.White;
                CL.Foreground = Brushes.White;
                Desu.Foreground = Brushes.White;
                PH.Foreground = Brushes.White;
                PM.Foreground = Brushes.White;
                PFF.Foreground = Brushes.White;
                PMN.Foreground = Brushes.White;
                PPG.Foreground = Brushes.White;
                PW.Foreground = Brushes.White;
                PEFF.Foreground = Brushes.White;
                Des_.Foreground = Brushes.White;
                nMd.Foreground = Brushes.White;
                HM.Foreground = Brushes.White;
                FM.Foreground = Brushes.White;
                LRAM_Menge.Foreground = Brushes.White;
                L_ATA_Menge.Foreground = Brushes.White;
                LFAN.Foreground = Brushes.White;
                WaküC.Foreground = Brushes.White;
                LP.Foreground = Brushes.White;
                HW_OCL.Foreground = Brushes.White;
                PSU_L.Foreground = Brushes.White;
                PSL.Foreground = Brushes.White;
                Save1L.Foreground = Brushes.White;
                Save2L.Foreground = Brushes.White;
                Save3L.Stroke = Brushes.White;
                Watt1L.Foreground = (Brush)bc.ConvertFrom("#FFFF0000");
                Watt2L.Foreground = (Brush)bc.ConvertFrom("#FFFF0000");
                Watt3L.Foreground = (Brush)bc.ConvertFrom("#FFFF0000");
                RAM_B2.Foreground = Brushes.White;
                RAM_B2.Background = (Brush)bc.ConvertFrom("#FF383838");
                RAM_B2.BorderBrush = Brushes.White;
                RAM_B1.Foreground = Brushes.White;
                RAM_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                RAM_B1.BorderBrush = Brushes.White;
                MB_B1.Foreground = Brushes.White;
                MB_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                MB_B1.BorderBrush = Brushes.White;
                CPU_B1.Foreground = Brushes.White;
                CPU_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                CPU_B1.BorderBrush = Brushes.White;
                GPU_B1.Foreground = Brushes.White;
                GPU_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                GPU_B1.BorderBrush = Brushes.White;
                Case_B1.Foreground = Brushes.White;
                Case_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                Case_B1.BorderBrush = Brushes.White;
                PSU_B1.Foreground = Brushes.White;
                PSU_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                PSU_B1.BorderBrush = Brushes.White;
                Save_B1.Foreground = Brushes.White;
                Save_B1.Background = (Brush)bc.ConvertFrom("#FF383838");
                Save_B1.BorderBrush = Brushes.White;
                Cal.Foreground = Brushes.White;
                Cal.Background = (Brush)bc.ConvertFrom("#FF383838");
                Cal.BorderBrush = Brushes.White;
                Win1C.Background = Brushes.Black;
                BT_C.Foreground = Brushes.Gray;
                BT_C.Background = (Brush)bc.ConvertFrom("#FF383838");
                AT_C.Foreground = Brushes.Gray;
                AT_C.Background = (Brush)bc.ConvertFrom("#FF383838");
                ET_C.Foreground = Brushes.Gray;
                ET_C.Background = (Brush)bc.ConvertFrom("#FF383838");
                CTabColor.Foreground = Brushes.Gray;
                CTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                MBTabColor.Foreground = Brushes.Gray;
                MBTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                RAMTabColor.Foreground = Brushes.Gray;
                RAMTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                GPUTabColor.Foreground = Brushes.Gray;
                GPUTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                CaseTabColor.Foreground = Brushes.Gray;
                CaseTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                PSUTabColor.Foreground = Brushes.Gray;
                PSUTabColor.Background = (Brush)bc.ConvertFrom("#FF383838");
                CPU_B.Foreground = Brushes.White;
                CPU_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                CPU_B.BorderBrush = Brushes.White;
                MB_B.Foreground = Brushes.White;
                MB_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                MB_B.BorderBrush = Brushes.White;
                RAM_B.Foreground = Brushes.White;
                RAM_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                RAM_B.BorderBrush = Brushes.White;
                GPU_B.Foreground = Brushes.White;
                GPU_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                GPU_B.BorderBrush = Brushes.White;
                Case_B.Foreground = Brushes.White;
                Case_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                Case_B.BorderBrush = Brushes.White;
                PSU_B.Foreground = Brushes.White;
                PSU_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                PSU_B.BorderBrush = Brushes.White;
                AP_Tab.Background = (Brush)bc.ConvertFrom("#FF383838");
                ATab.Background = (Brush)bc.ConvertFrom("#FF383838");
                PName.Foreground = Brushes.White;
                AK_Tab.Background = (Brush)bc.ConvertFrom("#FF383838");
                APT_Tab.Foreground = Brushes.Gray;
                APT_Tab.Background = (Brush)bc.ConvertFrom("#FF383838");
                AKT_Tab.Foreground = Brushes.Gray;
                AKT_Tab.Background = (Brush)bc.ConvertFrom("#FF383838");
                SaveP_Box.Background = Brushes.Black;
                SaveP_Box.Foreground = Brushes.White;
                SaveK_Box.Background = Brushes.Black;
                SaveK_Box.Foreground = Brushes.White;
                AK_B.Foreground = Brushes.White;
                AK_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                AK_B.BorderBrush = Brushes.White;
                AP_B.Foreground = Brushes.White;
                AP_B.Background = (Brush)bc.ConvertFrom("#FF383838");
                AP_B.BorderBrush = Brushes.White;

                a = 1;
            }
            #endregion
        }
    }
}

