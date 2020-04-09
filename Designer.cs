using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsLab2
{
    public partial class Designer : Form
    {
        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
        FormTractConfig form;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        private Logger logger;
        private Logger error;
        public Designer()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            error = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void buttonSetTraktor_Click(object sender, EventArgs e)
        {
            form = new FormTractConfig();
            form.AddEvent(Addtractor);
            form.Show();
        }
        private void Addtractor(ITransport tractor)
        {
            if (tractor != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + tractor;
                    logger.Info("Добавлен трактор " + tractor.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    logger.Debug("Ошибка: такой трактор уже есть на парковке");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeTraktor_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var tractor = parking[listBoxLevels.SelectedIndex] -
                            Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeTraktor.Width, pictureBoxTakeTraktor.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        tractor.SetPosition(5, 5, pictureBoxTakeTraktor.Width,
                        pictureBoxTakeTraktor.Height);
                        tractor.DrawTract(gr);
                        pictureBoxTakeTraktor.Image = bmp;
                        logger.Info("Изъят трактор " + tractor.ToString() + " с места " + maskedTextBox.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeTraktor.Width, pictureBoxTakeTraktor.Height);
                        pictureBoxTakeTraktor.Image = bmp;
                        error.Error(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error.Error(ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSetTractor_Click(object sender, EventArgs e)
        {
            form = new FormTractConfig();
            form.AddEvent(Addtractor);
            form.Show();
        }
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                    parking.SaveData(saveFileDialog1.FileName);
                     MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                try
                {
                    parking.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                 Draw();
             }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}