using System;
using System.Collections.Generic;
using System.Collections;
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

namespace chckckckckckckckckckckc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] field = new int[8, 8]; // size 64, num from 0 to 7

        bool isWhite;

        //добавляем все плиточки и картинки в коллекцию

        public ArrayList aFields = new ArrayList(); // создаём коллекцию
        public ArrayList aImages = new ArrayList(); // и для отображения шашечек


        public MainWindow()
        {
            InitializeComponent();

            GameStart();

            



        }



        public void GameStart()
        {
            FieldGeneration(isWhite);



        }

        public void Reloader()
        {
            Button tempb = new Button();
            Image tempi = new Image();
            int index = 0;

            for (int i = 0; i < field.GetLength(1); i++)
            {
                break; //temporary
                for (int j = 0; j < field.GetLength(2); j++)
                {

                    if (field[i, j] == 1)
                    {



                    }

                    index += 1;

                }

            }

        }

        public void FieldSet(int fieldNum, int operationNumber) //fieldNum - field[i]
                                                                // operationNumber
                                                                // 0 - clear from pic
                                                                // 1 - pic black,
                                                                // 2 - pic white,
                                                                // 3 - pic black queen,
                                                                // 4 - pic white queen,
                                                                // 5 - clear field color active, 
                                                                // 6 - make field color active
        {

            switch (operationNumber)
            {
                case 0:
                    switch (fieldNum)
                    {
                        case 0:
                            i1.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 1:
                            i2.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 2:
                            i3.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 3:
                            i4.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 4:
                            i5.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 5:
                            i6.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 6:
                            i7.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 7:
                            i8.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 8:
                            i9.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 9:
                            i10.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 10:
                            i11.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 11:
                            i12.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 12:
                            i13.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 13:
                            i14.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 14:
                            i15.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 15:
                            i16.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 16:
                            i17.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 17:
                            i18.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 18:
                            i19.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 19:
                            i20.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 20:
                            i21.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 21:
                            i22.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 22:
                            i23.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 23:
                            i24.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 24:
                            i25.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 25:
                            i26.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 26:
                            i27.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 27:
                            i28.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 28:
                            i29.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 29:
                            i30.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 30:
                            i31.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 31:
                            i32.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 32:
                            i33.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 33:
                            i34.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 34:
                            i35.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 35:
                            i36.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 36:
                            i37.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 37:
                            i38.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 38:
                            i39.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 39:
                            i40.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 40:
                            i41.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 41:
                            i42.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 42:
                            i43.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 43:
                            i44.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 44:
                            i45.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 45:
                            i46.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 46:
                            i47.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 47:
                            i48.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 48:
                            i49.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 49:
                            i50.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 50:
                            i51.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 51:
                            i52.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 52:
                            i53.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 53:
                            i54.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 54:
                            i55.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 55:
                            i56.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 56:
                            i57.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 57:
                            i58.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 58:
                            i59.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 59:
                            i60.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 60:
                            i61.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 61:
                            i62.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 62:
                            i63.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                        case 63:
                            i64.Source = new BitmapImage(new Uri(@"/", UriKind.Relative));
                            break;
                    }
                    break;
                case 1:
                    switch (fieldNum)
                    {
                        case 0:
                            i1.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 1:
                            i2.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 2:
                            i3.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 3:
                            i4.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 4:
                            i5.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 5:
                            i6.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 6:
                            i7.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 7:
                            i8.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 8:
                            i9.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 9:
                            i10.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 10:
                            i11.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 11:
                            i12.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 12:
                            i13.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 13:
                            i14.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 14:
                            i15.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 15:
                            i16.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 16:
                            i17.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 17:
                            i18.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 18:
                            i19.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 19:
                            i20.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 20:
                            i21.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 21:
                            i22.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 22:
                            i23.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 23:
                            i24.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 24:
                            i25.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 25:
                            i26.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 26:
                            i27.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 27:
                            i28.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 28:
                            i29.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 29:
                            i30.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 30:
                            i31.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 31:
                            i32.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 32:
                            i33.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 33:
                            i34.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 34:
                            i35.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 35:
                            i36.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 36:
                            i37.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 37:
                            i38.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 38:
                            i39.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 39:
                            i40.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 40:
                            i41.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 41:
                            i42.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 42:
                            i43.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 43:
                            i44.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 44:
                            i45.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 45:
                            i46.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 46:
                            i47.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 47:
                            i48.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 48:
                            i49.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 49:
                            i50.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 50:
                            i51.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 51:
                            i52.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 52:
                            i53.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 53:
                            i54.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 54:
                            i55.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 55:
                            i56.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 56:
                            i57.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 57:
                            i58.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 58:
                            i59.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 59:
                            i60.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 60:
                            i61.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 61:
                            i62.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 62:
                            i63.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                        case 63:
                            i64.Source = new BitmapImage(new Uri(@"/black.png", UriKind.Relative));
                            break;
                    }
                    break;
                case 2:
                    switch (fieldNum)
                    {
                        case 0:
                            i1.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 1:
                            i2.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 2:
                            i3.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 3:
                            i4.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 4:
                            i5.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 5:
                            i6.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 6:
                            i7.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 7:
                            i8.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 8:
                            i9.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 9:
                            i10.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 10:
                            i11.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 11:
                            i12.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 12:
                            i13.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 13:
                            i14.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 14:
                            i15.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 15:
                            i16.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 16:
                            i17.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 17:
                            i18.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 18:
                            i19.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 19:
                            i20.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 20:
                            i21.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 21:
                            i22.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 22:
                            i23.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 23:
                            i24.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 24:
                            i25.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 25:
                            i26.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 26:
                            i27.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 27:
                            i28.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 28:
                            i29.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 29:
                            i30.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 30:
                            i31.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 31:
                            i32.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 32:
                            i33.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 33:
                            i34.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 34:
                            i35.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 35:
                            i36.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 36:
                            i37.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 37:
                            i38.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 38:
                            i39.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 39:
                            i40.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 40:
                            i41.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 41:
                            i42.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 42:
                            i43.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 43:
                            i44.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 44:
                            i45.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 45:
                            i46.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 46:
                            i47.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 47:
                            i48.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 48:
                            i49.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 49:
                            i50.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 50:
                            i51.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 51:
                            i52.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 52:
                            i53.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 53:
                            i54.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 54:
                            i55.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 55:
                            i56.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 56:
                            i57.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 57:
                            i58.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 58:
                            i59.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 59:
                            i60.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 60:
                            i61.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 61:
                            i62.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 62:
                            i63.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                        case 63:
                            i64.Source = new BitmapImage(new Uri(@"/white.png", UriKind.Relative));
                            break;
                    }
                    break;
                case 3:
                    switch (fieldNum)
                    {
                        case 0:
                            i1.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 1:
                            i2.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 2:
                            i3.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 3:
                            i4.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 4:
                            i5.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 5:
                            i6.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 6:
                            i7.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 7:
                            i8.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 8:
                            i9.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 9:
                            i10.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 10:
                            i11.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 11:
                            i12.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 12:
                            i13.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 13:
                            i14.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 14:
                            i15.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 15:
                            i16.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 16:
                            i17.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 17:
                            i18.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 18:
                            i19.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 19:
                            i20.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 20:
                            i21.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 21:
                            i22.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 22:
                            i23.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 23:
                            i24.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 24:
                            i25.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 25:
                            i26.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 26:
                            i27.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 27:
                            i28.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 28:
                            i29.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 29:
                            i30.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 30:
                            i31.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 31:
                            i32.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 32:
                            i33.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 33:
                            i34.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 34:
                            i35.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 35:
                            i36.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 36:
                            i37.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 37:
                            i38.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 38:
                            i39.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 39:
                            i40.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 40:
                            i41.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 41:
                            i42.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 42:
                            i43.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 43:
                            i44.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 44:
                            i45.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 45:
                            i46.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 46:
                            i47.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 47:
                            i48.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 48:
                            i49.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 49:
                            i50.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 50:
                            i51.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 51:
                            i52.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 52:
                            i53.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 53:
                            i54.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 54:
                            i55.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 55:
                            i56.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 56:
                            i57.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 57:
                            i58.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 58:
                            i59.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 59:
                            i60.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 60:
                            i61.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 61:
                            i62.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 62:
                            i63.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                        case 63:
                            i64.Source = new BitmapImage(new Uri(@"/queenblack.png", UriKind.Relative));
                            break;
                    }
                    break;
                case 4:
                    switch (fieldNum)
                    {
                        case 0:
                            i1.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 1:
                            i2.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 2:
                            i3.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 3:
                            i4.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 4:
                            i5.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 5:
                            i6.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 6:
                            i7.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 7:
                            i8.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 8:
                            i9.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 9:
                            i10.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 10:
                            i11.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 11:
                            i12.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 12:
                            i13.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 13:
                            i14.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 14:
                            i15.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 15:
                            i16.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 16:
                            i17.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 17:
                            i18.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 18:
                            i19.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 19:
                            i20.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 20:
                            i21.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 21:
                            i22.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 22:
                            i23.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 23:
                            i24.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 24:
                            i25.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 25:
                            i26.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 26:
                            i27.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 27:
                            i28.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 28:
                            i29.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 29:
                            i30.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 30:
                            i31.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 31:
                            i32.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 32:
                            i33.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 33:
                            i34.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 34:
                            i35.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 35:
                            i36.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 36:
                            i37.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 37:
                            i38.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 38:
                            i39.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 39:
                            i40.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 40:
                            i41.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 41:
                            i42.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 42:
                            i43.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 43:
                            i44.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 44:
                            i45.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 45:
                            i46.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 46:
                            i47.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 47:
                            i48.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 48:
                            i49.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 49:
                            i50.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 50:
                            i51.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 51:
                            i52.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 52:
                            i53.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 53:
                            i54.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 54:
                            i55.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 55:
                            i56.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 56:
                            i57.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 57:
                            i58.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 58:
                            i59.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 59:
                            i60.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 60:
                            i61.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 61:
                            i62.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 62:
                            i63.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                        case 63:
                            i64.Source = new BitmapImage(new Uri(@"/queenwhite.png", UriKind.Relative));
                            break;
                    }
                    break;
                case 5:
                    switch (fieldNum)
                    {
                        case 0:
                            f1.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 1:
                            f2.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 2:
                            f3.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 3:
                            f4.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 4:
                            f5.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 5:
                            f6.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 6:
                            f7.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 7:
                            f8.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 8:
                            f9.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 9:
                            f10.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 10:
                            f11.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 11:
                            f12.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 12:
                            f13.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 13:
                            f14.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 14:
                            f15.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 15:
                            f16.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 16:
                            f17.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 17:
                            f18.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 18:
                            f19.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 19:
                            f20.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 20:
                            f21.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 21:
                            f22.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 22:
                            f23.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 23:
                            f24.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 24:
                            f25.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 25:
                            f26.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 26:
                            f27.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 27:
                            f28.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 28:
                            f29.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 29:
                            f30.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 30:
                            f31.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 31:
                            f32.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 32:
                            f33.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 33:
                            f34.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 34:
                            f35.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 35:
                            f36.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 36:
                            f37.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 37:
                            f38.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 38:
                            f39.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 39:
                            f40.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 40:
                            f41.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 41:
                            f42.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 42:
                            f43.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 43:
                            f44.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 44:
                            f45.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 45:
                            f46.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 46:
                            f47.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 47:
                            f48.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 48:
                            f49.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 49:
                            f50.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 50:
                            f51.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 51:
                            f52.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 52:
                            f53.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 53:
                            f54.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 54:
                            f55.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 55:
                            f56.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 56:
                            f57.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 57:
                            f58.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 58:
                            f59.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 59:
                            f60.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 60:
                            f61.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 61:
                            f62.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 62:
                            f63.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                        case 63:
                            f64.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF757DB4");
                            break;
                    }
                    break;
                case 6:
                    switch (fieldNum)
                    {
                        case 0:
                            f1.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 1:
                            f2.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 2:
                            f3.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 3:
                            f4.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 4:
                            f5.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 5:
                            f6.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 6:
                            f7.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 7:
                            f8.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 8:
                            f9.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 9:
                            f10.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 10:
                            f11.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 11:
                            f12.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 12:
                            f13.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 13:
                            f14.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 14:
                            f15.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 15:
                            f16.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 16:
                            f17.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 17:
                            f18.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 18:
                            f19.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 19:
                            f20.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 20:
                            f21.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 21:
                            f22.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 22:
                            f23.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 23:
                            f24.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 24:
                            f25.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 25:
                            f26.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 26:
                            f27.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 27:
                            f28.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 28:
                            f29.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 29:
                            f30.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 30:
                            f31.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 31:
                            f32.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 32:
                            f33.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 33:
                            f34.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 34:
                            f35.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 35:
                            f36.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 36:
                            f37.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 37:
                            f38.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 38:
                            f39.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 39:
                            f40.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 40:
                            f41.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 41:
                            f42.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 42:
                            f43.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 43:
                            f44.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 44:
                            f45.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 45:
                            f46.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 46:
                            f47.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 47:
                            f48.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 48:
                            f49.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 49:
                            f50.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 50:
                            f51.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 51:
                            f52.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 52:
                            f53.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 53:
                            f54.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 54:
                            f55.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 55:
                            f56.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 56:
                            f57.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 57:
                            f58.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 58:
                            f59.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 59:
                            f60.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 60:
                            f61.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 61:
                            f62.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 62:
                            f63.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                        case 63:
                            f64.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF9296B2");
                            break;
                    }
                    break;
                default:
                    throw new Exception("operationNumber in FieldSet() out of bound");
                    break;
            }

        }

        public int[,] FieldGeneration(bool isWhite)
        {

            if (isWhite) //white bottom
            {
                for (int i = 0; i < 8; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {

                        if (i != 3 && i != 4)
                        {

                            if (i % 2 == 0 && j % 2 == 0)
                            {

                                if (i < 3)
                                    field[i, j] = 1; //bcs 1 is black and 2 is white

                                else
                                    field[i, j] = 2;

                            }

                            if (i % 2 == 1 && j % 2 == 1)
                            {

                                if (i < 3)
                                    field[i, j] = 1; //bcs 1 is black and 2 is white

                                else
                                    field[i, j] = 2;

                            }

                        }
                        else field[i, j] = 0;

                    }


                }
            }

            if (!isWhite) //black bottom
            {
                for (int i = 0; i < 8; i++)
                {

                    for (int j = 0; j < 8; j++)
                    {

                        if (i != 3 && i != 4)
                        {

                            if (i % 2 == 0 && j % 2 == 0)
                            {

                                if (i < 3)
                                    field[i, j] = 2; //bcs 1 is black and 2 is white

                                else
                                    field[i, j] = 1;

                            }

                            if (i % 2 == 1 && j % 2 == 1)
                            {

                                if (i < 3)
                                    field[i, j] = 2; //bcs 1 is black and 2 is white

                                else
                                    field[i, j] = 1;

                            }

                        }
                        else field[i, j] = 0;

                    }


                }
            }
            //string out1 = "";

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++) out1 += field[i, j]; // ctrl + k ctrl + c !!!! ctrl + k ctrl + u for remove
            //    out1 += "\n";
            //}

            //t1.Text = out1;

            return field;

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e) // для девочьки с сердечьками
        {
            isWhite = true;
            GameStart();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e) // для мальчика с цветочьком
        {
            isWhite = false;
            GameStart();
        }
    }


}
