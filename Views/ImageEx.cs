using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Data;

namespace Mfg.View
{
    public class ImageEx : System.Windows.Controls.Image
    {
        //static ImageEx()
        //{
        //    var metaData  = SourceProperty.GetMetadata(typeof(ImageEx));
        //    SourceProperty.OverrideMetadata(typeof(ImageEx), new FrameworkPropertyMetadata()
        //    {
        //        DefaultValue = metaData.DefaultValue,
        //        CoerceValueCallback = metaData.CoerceValueCallback,
        //        PropertyChangedCallback = new PropertyChangedCallback(prop),
        //    });
        //}

        public ImageEx()
            : base()
        {
        }

        public bool IsAsync
        {
            get { return (bool)GetValue(IsAsyncProperty); }
            set { SetValue(IsAsyncProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsAsync.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAsyncProperty =
            DependencyProperty.Register("IsAsync", typeof(bool), typeof(ImageEx),
            new PropertyMetadata()
            {
                DefaultValue = true,
                PropertyChangedCallback = new PropertyChangedCallback(prop),
                //CoerceValueCallback = new CoerceValueCallback(coerce),
            });

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            //var img = obj as ImageEx;
            var bindExpress = this.GetBindingExpression(ImageEx.SourceProperty);
            var bind = bindExpress.ParentBinding;
            if (bind != null)
            {
                var newBind = new Binding()
                {
                    Path = bind.Path,
                    Mode = bind.Mode,
                    UpdateSourceTrigger = bind.UpdateSourceTrigger,
                    IsAsync = this.IsAsync,

                };

                //var metaData = SourceProperty.GetMetadata(typeof(ImageEx));
                //SourceProperty.OverrideMetadata((typeof(ImageEx), new FrameworkPropertyMetadata()
                //{
                //    DefaultValue = metaData.DefaultValue,
                //    CoerceValueCallback = metaData.CoerceValueCallback,
                //    //PropertyChangedCallback = new PropertyChangedCallback(prop),
                //});

                this.SetBinding(ImageEx.SourceProperty, newBind);

                //metaData = SourceProperty.GetMetadata(typeof(ImageEx));
                //SourceProperty.OverrideMetadata(typeof(ImageEx), new FrameworkPropertyMetadata()
                //{
                //    DefaultValue = metaData.DefaultValue,
                //    CoerceValueCallback = metaData.CoerceValueCallback,
                //    PropertyChangedCallback = new PropertyChangedCallback(prop),
                //});
            }
        }

        private static void prop(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var img = obj as ImageEx;
            var bindExpress = img.GetBindingExpression(ImageEx.SourceProperty);
            var bind = bindExpress.ParentBinding;
            if (bind != null)
            {
                var newBind = new Binding()
                {
                    Path = bind.Path,
                    Mode = bind.Mode,
                    UpdateSourceTrigger = bind.UpdateSourceTrigger,
                    IsAsync = img.IsAsync,

                };

                //var metaData = SourceProperty.GetMetadata(typeof(ImageEx));
                //SourceProperty.OverrideMetadata((typeof(ImageEx), new FrameworkPropertyMetadata()
                //{
                //    DefaultValue = metaData.DefaultValue,
                //    CoerceValueCallback = metaData.CoerceValueCallback,
                //    //PropertyChangedCallback = new PropertyChangedCallback(prop),
                //});

                img.SetBinding(ImageEx.SourceProperty, newBind);

                //metaData = SourceProperty.GetMetadata(typeof(ImageEx));
                //SourceProperty.OverrideMetadata(typeof(ImageEx), new FrameworkPropertyMetadata()
                //{
                //    DefaultValue = metaData.DefaultValue,
                //    CoerceValueCallback = metaData.CoerceValueCallback,
                //    PropertyChangedCallback = new PropertyChangedCallback(prop),
                //});
            }
        }

        //private static object coerce(DependencyObject obj, object e)
        //{
        //    var img = obj as ImageEx;
        //    var bindExpress = img.GetBindingExpression(ImageEx.SourceProperty);
        //    var bind = bindExpress.ParentBinding;
        //    if (bind != null)
        //    {
        //        var newBind = new Binding()
        //        {
        //            Path = bind.Path,
        //            Mode = bind.Mode,
        //            UpdateSourceTrigger = bind.UpdateSourceTrigger,
        //            IsAsync = img.IsAsync,

        //        };
        //        img.SetBinding(ImageEx.SourceProperty, newBind);
        //    }
        //    return img.IsAsync;
        //}
    }
}
