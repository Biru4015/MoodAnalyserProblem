using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyserProblemTest
{
    class MoodAnalyesrFactory<Gtype>
    {
        public ConstructorInfo GetDefaultConstructor()
        {
            try
            {
                Type type = typeof(Gtype);
                ConstructorInfo[] constructor = type.GetConstructors();

                // sending defalut constructor => parameters are 0
                foreach (var info in constructor)
                {
                    if (info.GetParameters().Length == 0)
                        return info;
                }

                return constructor[0];
            }
            catch(Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Deffination is not found , Please enter valid Class");
            }
        }

        public object GetInstance(string class_name, ConstructorInfo constructor)
        {
            try
            {
                // create type using given type
                Type type = typeof(Gtype);
                // given class not equals to type name throw exception
                if (class_name != type.Name)
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No such class");
                // given constructor name is not equals to constructor of type throw exception
                if (constructor != type.GetConstructors()[0])
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No such Method Found");
                var Object_return = constructor.Invoke(new object[0]);
                Gtype Obj_return = Activator.CreateInstance<Gtype>();
                return Object_return;
            }
            catch (Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Error_in_Object_Creation, "Error occured in Object creation in GetInstance Method");
            }

        }
    }
}
