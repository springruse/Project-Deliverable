using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                         throw new InvalidIdException();
                    }

                }
                catch (InvalidIdException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
        public string Name { get; set; }
    }
}
