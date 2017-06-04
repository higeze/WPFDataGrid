using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using SampleWPFApplication.Models;

namespace SampleWPFApplication.ViewModels
{
    public class CuttingParameterTemplateSelector : DataTemplateSelector
    {

        public DataTemplate TurningTemplate

        { get; set; }



        public DataTemplate MillingTemplate

        { get; set; }



        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
            {
                if ((item as Person).CuttingParameters.Count > 0)
                {

                    if ((item as Person).CuttingParameters[0] is TurningParameter)
                    {
                        return TurningTemplate;
                    }
                    else if ((item as Person).CuttingParameters[0] is MillingParameter)
                    {
                        return MillingTemplate;
                    }
                }
            }
            //    switch ((item as Person).CuttingParameters[0].Process)
            //    {
            //        case "Turning":
            //            return TurningTemplate;
            //        case "Milling":
            //            return MillingTemplate;
            //        default:
            //            return base.SelectTemplate(item, container);
            //    }
            //}
            return base.SelectTemplate(item, container);
        }

    }
}
