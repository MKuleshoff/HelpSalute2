using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Fptr10Lib;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace HelpSalute
{

    public partial class Form1 : Form
    {

        public static string loginFokus, passfokus, loginspar, passpar, loginks, passks, logintruda, passtruda, loginkashirinih, passkashirinih, logingagarina, passgagarina, loginmechnikova, passmechnikova, logingorki, passgorki, loginkolco, passkolco, loginenergetikov, passenergetikov;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
         //   var psi = new ProcessStartInfo();
                       
         //   Process.Start("CMD");
            string strCmdText;
                        
            strCmdText = @"/C del /f /q %systemroot%\system32\spool\printers\*.shd \n del /f /q %systemroot%\system32\spool\printers\*.spl";
            MessageBox.Show("Через 3 минуты пробуйте распечатать");
            
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
         
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите и удерживайте кнопку СТОП и Кнопку ОК одновременно. Если нету у Вас кнопки ОК на принтере то есть кнопка повтарить и т.д. Держать кнопки надо одновременно пока принтер не заработает");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string strCmdText;

            strCmdText = @"/C rd /s /q %PUBLIC%\Documents\kyocera";
            MessageBox.Show("Пробуйте отсканировать");

            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string strCmdText, strcmdcommand;
          
            strCmdText = @"/C FOR /D %i in (%LOCALAPPDATA%\1C\1Cv82\????????-????-????-????-????????????) do rd /s /q %i ";
            strcmdcommand = @"/C FOR /D %i in (%APPDATA%\1C\1Cv82\????????-????-????-????-????????????) do rd /s /q %i";
            
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", strcmdcommand);
            MessageBox.Show("Пробуйте запустить 1С");
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            System.Net.NetworkInformation.Ping png = new Ping();
            System.Net.NetworkInformation.PingReply pingReply = png.Send("tdupz.ru");
            if (pingReply.Status == IPStatus.Success)
               MessageBox.Show("Соединение утсановлено... Перезапустите 1С  и повторите попытку");


            else MessageBox.Show("Имеются проблемы со связью. Перезагрузите компьютер.После запуска 1с миунт через 15-20 повторите попытку. ");

           // MessageBox.Show("Перезагрузите компьютер и после запуска 1с миунт через 15-20 повторите попытку.");

        }

        private void Button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Позвоните Кулешову М.С. По номеру 89995707595");
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            IFptr fptr = new Fptr();
            fptr.open();
            fptr.setParam(1021, "");
            //fptr.setParam(1203, "");
            fptr.operatorLogin();
            //fptr.setParam()
           fptr.setParam(fptr.LIBFPTR_PARAM_REPORT_TYPE, fptr.LIBFPTR_RT_CLOSE_SHIFT);
            fptr.report();
            //MessageBox.Show(fptr.report());
            // fptr.checkDocumentClosed();
            fptr.close();
            fptr.destroy();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("help@magsalutov.ru", "HelpSalut");
            // кому отправляем
            MailAddress to = new MailAddress("help@magsalutov.ru"+";"+" m.kuleshov@tdupz.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Пароль от почты";
            // текст письма
            m.Body = "<h2>Забыл(а) Пароль от почты </h2>" + combomag.Text ;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("help@magsalutov.ru", "salut123");
            //client.UseDefaultCredentials = true;
           // smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Send(m);
            //Console.Read();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("help@magsalutov.ru", "HelpSalut");
            // кому отправляем
            MailAddress to = new MailAddress("help@magsalutov.ru" + ";" + " m.kuleshov@tdupz.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Пароль от 1C";
            // текст письма
            m.Body = "<h2>Забыл(а) Пароль от 1C  </h2>" + txtFio.Text;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("help@magsalutov.ru", "salut123");
            //client.UseDefaultCredentials = true;
            // smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            //Fokus
            loginFokus = "u14787";
            passfokus = "W880913Ggn";
            //Gorki
            logingorki = "u14768";
            passgorki = "AhmDk9c172";
            //Spar
            loginspar = "u14781";
            passpar = "0VeLkyO7AL";
            //Truda
            logintruda = "u14783";
            passtruda = "j5z9n427O0";
            //Gagarina
            logingagarina = "";
            passgagarina = "";
            //KS
            loginks = "u14786";
            passks = "0pcm9kqU0s";
            //Mechnikova
            loginmechnikova = "";
            passmechnikova = "";
            //kolco
            loginkolco = "u14767";
            passkolco = "WRmD8El6qt";
            //Energetikov
            loginenergetikov = "u14782";
            passenergetikov = "y3h8A0kOSj";
            //Kashirinih
            loginkashirinih = "u14784";
            passkashirinih = "svbe8jV9wg";
//Fokus
            if (combopvz.Text == "Боксбери " && combomag.Text == "Фокус")
            {
                txtpvz.Text = ($"Логин: {loginFokus} Пароль: {passfokus}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }

            //Gorki
            if (combopvz.Text == "Боксбери " && combomag.Text == "Горки")
            {
                txtpvz.Text = ($"Логин: {logingorki} Пароль: {passgorki}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }
            //Spar
            if (combopvz.Text == "Боксбери " && combomag.Text == "Спар")
            {
                txtpvz.Text = ($"Логин: {loginspar} Пароль: {passpar}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }
            //Truda
            if (combopvz.Text == "Боксбери " && combomag.Text == "Труда")
            {
                txtpvz.Text = ($"Логин: {logintruda} Пароль: {passtruda}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }
            //kolco
            if (combopvz.Text == "Боксбери " && combomag.Text == "Кольцо")
            {
                txtpvz.Text = ($"Логин: {loginkolco} Пароль: {passkolco}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }
            //KS
            if (combopvz.Text == "Боксбери " && combomag.Text == "КС")
            {
                txtpvz.Text = ($"Логин: {loginks} Пароль: {passks}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }
            //Energetokov
            if (combopvz.Text == "Боксбери " && combomag.Text == "Энергетиков")
            {
                txtpvz.Text = ($"Логин: {loginenergetikov} Пароль: {passenergetikov}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }
            //Kashirinich
            if (combopvz.Text == "Боксбери " && combomag.Text == "Кашириных")
            {
                txtpvz.Text = ($"Логин: {loginkashirinih} Пароль: {passkashirinih}");

            }
            else
            {
                MessageBox.Show("Не выбран магазин");
            }

        }
    }
}
//Добавить картинки
//После сканера рекомендуется ребут 
//Изменить порядок очистки кеша
