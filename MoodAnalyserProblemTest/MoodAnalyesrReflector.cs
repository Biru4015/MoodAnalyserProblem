using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MoodAnalyserProblemTest;

namespace MoodAnalyserProblemTest
{
    class MoodAnalyesrReflecotr<Gtype>
    {
        public ConstructorInfo GetDefaultConstructor(int num_parameters=0)
        {
            try
            {
                Type type = typeof(Gtype);
                ConstructorInfo[] constructor = type.GetConstructors();

                // sending defalut constructor => parameters are 0
                foreach (var info in constructor)
                {
                    if (info.GetParameters().Length == num_parameters)
                        return info;
                }
                return constructor[0];
            }
            catch(Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Deffination is not found , Please enter valid Class");
            }
        }

        /// <summary>
        /// Method to create and return object 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method is created for get parameterized object
        /// </summary>
        /// <param name="class_name"></param>
        /// <param name="constructor"></param>
        /// <param name="parameterValue"></param>
        /// <returns>object</returns>
        public object GetParameterizedInsatance(string class_name, ConstructorInfo constructor, string parameterValue)
        {
            // create type using given type
            Type type = typeof(Gtype);
            // given class not equals to type name throw exception
            if (class_name != type.Name)
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No such class");
            // given constructor name is not equals to constructor of type throw exception
            if (constructor != type.GetConstructors()[1])
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No such Method Found");
            // create instance with constructor
            //var Object_return = constructor.Invoke(); 
            //creating instance using parametersised constructor
            Object Object_return = Activator.CreateInstance(type, parameterValue);
            return Object_return;

        }

        /// <summary>
        /// This method is created for use reflection for invoke method
        /// </summary>
        public string InvokeMoodAnalyser()
        {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalysertype = Type.GetType("AnalyseMood.MoodAnalyser");
                MethodInfo methodInfo = moodAnalysertype.GetMethod("MoodAnalyser");
                string[] stringArray = { "I am in Happy mood" };
                object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);
                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;
            
        }
    }
}
