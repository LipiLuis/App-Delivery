using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppFooD.Helps
{
    public class NotifyBase : INotifyPropertyChanged //, IDataErrorInfo
    {



        //public delegate void ErrorEvent(string Msg);

        //public event ErrorEvent Error;


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            try
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {
                //https://docs.devexpress.com/WindowsForms/751/controls-and-libraries/data-grid/data-editing-and-validation/errorinfo-support/error-notification-support-for-data-sources

                string erro = ex.Message;
                //    PropertyErrors[propertyName] = erro;
                //throw;
                // ErrorPropChanged(erro);
            }
        }

        protected bool SetProperty<T>(ref T _backField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(_backField, value))
            {
                return false;
            }

            //try
            //{
            //ValidateValue(value, propertyName);
            //  PropertyErrors.Remove(propertyName);

            _backField = value;
            OnPropertyChanged(propertyName);

            return true;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        //// Stores errors for all properties of the Customer class.
        //[XmlIgnore]
        //public Dictionary<string, string> PropertyErrors = new Dictionary<string, string>();
        //string IDataErrorInfo.this[string propertyName]
        //{
        //    get
        //    {
        //        string errorText;
        //        return PropertyErrors.TryGetValue(propertyName, out errorText) ? errorText : null;
        //    }
        //}
        //[XmlIgnore]
        //string IDataErrorInfo.Error => string.Empty;

        //public string ValidateObject()
        //{
        //    ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
        //    List<ValidationResult> results = new List<ValidationResult>();
        //    bool isValid = Validator.TryValidateObject(this, context, results, true);

        //    if (isValid)
        //    {
        //        return "OK";
        //    }
        //    else
        //    {
        //        var sbrErrors = new StringBuilder();
        //        foreach (var validationResult in results)
        //        {
        //            sbrErrors.AppendLine(validationResult.ErrorMessage);
        //        }

        //        return sbrErrors.ToString();
        //    }
        //}

        // Clears or sets errors for the FirstName and LastName fields.
        //void ValidateValue<T>(T value, [CallerMemberName] String propertyName = "")
        //{
        //    if (value != null)
        //    {
        //        bool isValid = !string.IsNullOrEmpty(value.ToString());
        //        if (isValid)
        //        {
        //            //Clear a previous error, if any.
        //            PropertyErrors.Remove(propertyName);
        //        }
        //        else
        //        {
        //            //Set an error.
        //            string errorText = propertyName + " is required";
        //            PropertyErrors[propertyName] = errorText;
        //        }
        //    }
        //}



    }
}
