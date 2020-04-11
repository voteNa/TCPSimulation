using System;
using Avalonia.Markup.Xaml;
using NetworkSimulator.ViewModels;

namespace NetworkSimulator.Views
{
    public class DistributionTypeBindingSource : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new[]
            {
                DistributionType.Exponential,
            };
        }
    }
}
