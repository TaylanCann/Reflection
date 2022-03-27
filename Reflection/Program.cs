using System;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            //Reflection, using for get class name  
            #region GetTypeName
            var getTypeName = user.GetType().Name;
            Console.WriteLine(getTypeName);
            #endregion  

            //Reflection, using for get class properties
            #region GetTypeProperties
            var getTypeProperties = user.GetType().GetProperties();
            for (int i = 0; i < getTypeProperties.Length; i++)
            {
                Console.WriteLine(getTypeProperties[i]);
            }
            #endregion

            //Reflection, using for get class specific property
            #region GetTypeProperty
            var getTypeProperty = user.GetType().GetProperty("Surname");
            Console.WriteLine(getTypeProperty);
            #endregion

            //Reflection, using for get and set class properties
            #region GetSetValue
            var surname = getTypeProperty.GetValue(user, null);
            getTypeProperty.SetValue(user, "TaylanCanHardal", null);
            surname = getTypeProperty.GetValue(user, null);
            Console.WriteLine(surname);
            #endregion

        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
