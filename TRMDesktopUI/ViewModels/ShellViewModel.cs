using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using TRMDesktopUI.EventModels;

namespace TRMDesktopUI.ViewModels
{
    public class ShellViewModel: Conductor<object>,IHandle<LogOnEvent>
    {
        private LoginViewModel _loginVM;
        private IEventAggregator _events;
        private SalesViewModel _salesVW;
        private SimpleContainer _container;
        public ShellViewModel(IEventAggregator events, SalesViewModel salesVW, 
            SimpleContainer container)
        {
            _events = events;            
            _container = container;
            _salesVW = salesVW;
            _events.Subscribe(this);
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVW);
        }
    }
}
