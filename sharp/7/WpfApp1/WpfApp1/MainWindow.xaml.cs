using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public class Knopka
    {
        protected int locationX;
        protected int locationY;
        protected int razmer;
        protected int width;
        protected int height;

        public Knopka()
        {
        }

        public int LocationX { get => locationX; set => locationX = value; }
        public int LocationY { get => locationY; set => locationY = value; }
        public int Razmer { get => razmer; set => razmer = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
 
    }


    public partial class MainWindow : Window
    {
        ObservableCollection<Knopka> spisoki = new ObservableCollection<Knopka>();


        public MainWindow()
        {
            
            InitializeComponent();
            spisok.ItemsSource = spisoki;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Knopka knopka = new Knopka();

            knopka.Width = int.Parse(Width.Text);
            knopka.Height = int.Parse(Height.Text);
            knopka.LocationX = int.Parse(LocatinX.Text);
            knopka.LocationY = int.Parse(LocationY.Text);
            knopka.Razmer = int.Parse(Razmer.Text);
            
            spisoki.Add(knopka);

            LocatinX.Text = "";
            LocationY.Text = "";
            Height.Text = "";
            Width.Text = "";
            Razmer.Text = "";
        }

        private void Remow_Click(object sender, RoutedEventArgs e)
        {

            if (spisok.SelectedItem is Knopka ty)
            {
                spisoki.Remove(ty);
                spisok.SelectedItem = null;

                LocatinX.Text = "";
                LocationY.Text = "";
                Height.Text = "";
                Width.Text = "";
                Razmer.Text = "";
            }
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}




//public class Avtobus
//{
//    public string Model { get; set; }
//    public int SidMesta { get; set; }
//    public int StojaMesta { get; set; }
//    public int Etazhi { get; set; }
//    public bool InvalidMesta { get; set; }

//    public Avtobus() //конструктор по умолчанию 

//    {

//        this.Model = "Икарус";
//        this.SidMesta = 25;
//        this.StojaMesta = 50;
//        this.Etazhi = 1;
//        this.InvalidMesta = true;

//    }

//    public Avtobus(Avtobus n) //конструктор по умолчанию (и базовый по умолчанию)

//    {
//        this.Model = n.Model;
//        this.SidMesta = n.SidMesta;
//        this.StojaMesta = n.StojaMesta;
//        this.Etazhi = n.Etazhi;
//        this.InvalidMesta = n.InvalidMesta;
//    }

//}



//public partial class MainWindow : Window
//{
//    ObservableCollection<Avtobus> spisokk = new ObservableCollection<Avtobus>();//используем спец класс коллекций для реализации обновлений
//    Avtobus redaktbuss;
//    public MainWindow()
//    {
//        InitializeComponent();// привязка вводимых данных к таблице(грид)
//        Tablica.ItemsSource = spisokk;

//        redaktbuss = null;

//    }

//    private void Button_Click(object sender, RoutedEventArgs e)
//    {
//        Avtobus bus1 = new Avtobus();



//        bus1.Model = Model.Text;

//        int res1; int res2; int res3;
//        bool isNumber1 = Int32.TryParse(SidMesta.Text, out res1);
//        if (isNumber1)
//        { bus1.SidMesta = res1; }
//        // res1 результат преобразования
//        //isNumber результат проверки = true\false


//        bool isNumber2 = Int32.TryParse(MestaStoya.Text, out res2);
//        if (isNumber2)
//        { bus1.StojaMesta = res2; }



//        bool isNumber3 = Int32.TryParse(Etazi.Text, out res3);
//        if (isNumber3)
//        { bus1.Etazhi = res3; }

//        bus1.InvalidMesta = (bool)Invalid.IsChecked;

//        //{ bus1.SidMesta = int.Parse(SidMesta.Text); }
//        // bus1.StojaMesta = int.Parse(MestaStoya.Text);
//        // bus1.Etazhi = int.Parse(Etazi.Text);

//        if (isNumber1 == true && isNumber2 == true && isNumber3 == true)
//        {
//            spisokk.Add(bus1);
//        }





//        Model.Text = "";
//        SidMesta.Text = "";
//        MestaStoya.Text = "";
//        Etazi.Text = "";
//        Invalid.IsChecked = false;

//    }

//    private void Tablica_SelectionChanged(object sender, SelectionChangedEventArgs e)
//    {
//        if (Tablica.SelectedItem is Avtobus avt)// переносит выбранные данные из грида в поля ввода
//        {
//            Model.Text = avt.Model;
//            SidMesta.Text = avt.SidMesta.ToString();
//            MestaStoya.Text = avt.StojaMesta.ToString();
//            Etazi.Text = avt.Etazhi.ToString();
//            Invalid.IsChecked = avt.InvalidMesta;

//            redaktbuss = avt;
//        }

//    }

//    private void Edit_Click(object sender, RoutedEventArgs e)
//    {


//        redaktbuss.Model = Model.Text;

//        int res1; int res2; int res3;
//        bool isNumber1 = Int32.TryParse(SidMesta.Text, out res1);
//        if (isNumber1)
//        { redaktbuss.SidMesta = res1; }

//        bool isNumber2 = Int32.TryParse(MestaStoya.Text, out res2);
//        if (isNumber2)
//        { redaktbuss.StojaMesta = res2; }



//        bool isNumber3 = Int32.TryParse(Etazi.Text, out res3);
//        if (isNumber3)
//        { redaktbuss.Etazhi = res3; }

//        redaktbuss.InvalidMesta = (bool)Invalid.IsChecked;

//        if (isNumber1 == true && isNumber2 == true && isNumber3 == true)
//        {
//            int i = spisokk.IndexOf(redaktbuss);//находим индекс редактируемого автобуса

//            Avtobus bus2 = new Avtobus(redaktbuss);//создаем копию редактбуса
//            spisokk[i] = bus2;// в список по найденному индексу записываем копию редактобуса
//        }



//        Model.Text = "";
//        SidMesta.Text = "";
//        MestaStoya.Text = "";
//        Etazi.Text = "";
//        Invalid.IsChecked = false;
//    }

//    private void Exit_Click(object sender, RoutedEventArgs e)
//    {
//        this.Close();
//    }

//    private void Delite_Click(object sender, RoutedEventArgs e)
//    {

//        if (Tablica.SelectedItem is Avtobus avt)
//        {

//            spisokk.Remove(avt);
//            Tablica.SelectedItem = null;

//            Model.Text = "";
//            SidMesta.Text = "";
//            MestaStoya.Text = "";
//            Etazi.Text = "";
//            Invalid.IsChecked = false;

//        }

//    }

//}

//}