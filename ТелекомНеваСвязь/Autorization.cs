using System.Runtime.CompilerServices;

namespace ТелекомНеваСвязь
{
    public partial class Autorization : Form
    {
        // Просто списки из чисел номеров сторудников и их паролей
        // Потом сделаю из БД
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        int[] passwords = new int[5] { 1, 2, 3, 4, 5 };

        // Сгенерированный код для входа
        string? code;

        // Время после закрытия окна с кодом
        DateTime startTime;

        public Autorization()
        {
            // Создаем окно
            InitializeComponent();

            // При нажатии клавиши Enter вызываем функции (в зависимости от того, в каком поле это
            // было нажато
            NumberTextBox.KeyDown += new KeyEventHandler(NumberEnterDown);
            PasswordTextBox.KeyDown += new KeyEventHandler(PasswordEnterDown);
            CodeTextBox.KeyDown += new KeyEventHandler(CodeEnterDown);
        }

        // Дейсвия при нажатии клавиши в поле номера сотрудника
        private void NumberEnterDown(object sender, KeyEventArgs e)
        {
            // Если нажали Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Получаем число из поля номера сотрудника
                int number = Convert.ToInt32(NumberTextBox.Text);
                // Сначала считаем что номер неверный
                bool isCorrectNumber = false;

                // Проходим по всем номерам сотрудников
                foreach (int num in numbers)
                {
                    // Если есть такой номер в списке
                    if (num == number)
                    {
                        // Открываем на ввод поле пароля
                        PasswordTextBox.Enabled = true;
                        // Переносим туда курсор
                        PasswordTextBox.Focus();
                        isCorrectNumber = true;
                        break;
                    }
                }
                // Если сотрудника с таким номером нет
                if (!isCorrectNumber)
                    MessageBox.Show("Вы ввели неверный номер сотрудника! Вам отказано в доступе!");
            }
        }
        // Дейсвия при нажатии клавиши в поле номера сотрудника
        private void PasswordEnterDown(object sender, KeyEventArgs e)
        {
            // Если нажали Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Получаем число из поля пароля сотрудника
                int password = Convert.ToInt32(PasswordTextBox.Text);
                // Сначала считаем что номер неверный
                bool isCorrectPassword = false;

                // Проходим по всем паролям сотрудников
                foreach (int pass in passwords)
                {
                    // Если есть такой пароль есть в списке
                    if (pass == password)
                    {
                        // Открываем на ввод поле кода
                        CodeTextBox.Enabled = true;
                        // Открываем кнопку получения нового кода
                        ButtonNewCode.Enabled = true;
                        // Открываем кнопку на вход
                        ButtonIn.Enabled = true;
                        // Переносим курсор в поле кода
                        CodeTextBox.Focus();
                        isCorrectPassword = true;

                        // Генерируем код
                        GenerateCode();

                        break;
                    }
                }
                // Если пароль неверный
                if (!isCorrectPassword)
                    MessageBox.Show("Вы ввели неверный пароль! Вам отказано в доступе!");
            }
        }
        // Дейсвия при нажатии клавиши в поле номера сотрудника
        private void CodeEnterDown(object sender, KeyEventArgs e)
        {
            // Если нажали Enter, то проверяем правильность кода
            if (e.KeyCode == Keys.Enter) CheckCode();
        }

        // Генерируем код
        private void GenerateCode()
        {
            // Изначально от пустой
            code = "";
            // Создаем объект для получения случайных чисед
            Random rand = new Random();
            for (int i = 0; i < 8; i++)
            {
                // Получаем символ по его номеру в таблице кодировки
                char letter = (char)rand.Next(33, 125);
                // Добавляем символ к коду
                code += letter;
            }
            MessageBox.Show($"Ваш код для входа в систему: {code}");
            // Получаем текущее время после закрытия окошка с кодом для входа
            startTime = DateTime.Now;
        }

        // Проверяем введеный код на правильность
        private void CheckCode()
        {
            // Получаем текущее время в момент начала проверки
            DateTime time = DateTime.Now;
            // Если код введен меньше чем за 10 секунд после его получения, то проверяем его
            if ((time - startTime).Seconds < 10)
            {
                // Получаем код из поля и сравниваем его со сгенерированным
                string c = CodeTextBox.Text;

                if (c == code)
                    MessageBox.Show("Вы успешно вошли в систему!");
                else
                    MessageBox.Show("Вы ввели неверный код! Вам отказано в доступе!");
            }
            else
                MessageBox.Show("Время на ввод кода закончилось! Сгенерируйте новый код");
        }

        // Кнопка отмены (просто обноляет все поля)
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            NumberTextBox.Text = "";
            PasswordTextBox.Text = "";
            CodeTextBox.Text = "";
        }

        // При нажатии на кнопку получения нового кода вызываем функции генерации нового кода
        private void ButtonNewCode_Click(object sender, EventArgs e) => GenerateCode();

        // При нажатии на кнопку вход проверяем правильность кода
        private void ButtonIn_Click(object sender, EventArgs e) => CheckCode();
    }
}