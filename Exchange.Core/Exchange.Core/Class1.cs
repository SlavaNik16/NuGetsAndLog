namespace Exchange.Core
{
    /// <summary>
    /// Ядро обменника(библиотека) 
    /// </summary>
    public class ExchangeCore
    {
        private readonly decimal Course;
        /// <summary>
        /// Конструктор
        /// </summary>
        public ExchangeCore(decimal Course)
        {
            this.Course = Course;
        }
        /// <summary>
        /// Вычисляет значение по раннее введеному курсу
        /// </summary>

        public decimal Cal(decimal money) => Course * money;
    }
}
