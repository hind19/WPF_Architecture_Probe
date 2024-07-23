using AutoMapper;
using CleanArchWPF.Helpers;
using CleanArchWPF.Models;
using Dispatcher;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;


namespace CleanArchWPF
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<TaskModel> taskModels;
        private readonly IUiOperator? _uiOperator;
        private readonly IMapper? _mapper;

        public MainWindowVM()
        {
            TaskList = new ObservableCollection<TaskModel>();
            ViewLoadedCommand = new RelayCommand(ViewLoadedHandler);
            _mapper = App.AppHost.Services.GetService<IMapper>();
            _uiOperator = App.AppHost.Services.GetRequiredService<IUiOperator>();
        }

        public MainWindowVM(IUiOperator uiOperator, IMapper mapper)
        {
            ViewLoadedCommand = new RelayCommand(ViewLoadedHandler);
            _uiOperator = uiOperator;
            _mapper = mapper;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        
        public ICommand ViewLoadedCommand { get; set; }
        
        public ObservableCollection<TaskModel> TaskList
        {
            get
            {
                return taskModels;
            }

            set
            {
                if (value != taskModels)
                {
                    taskModels = value;
                    NotifyPropertyChanged();
                }
            }
        }
       
        public void ViewLoadedHandler(object obj)
        {
            TaskList = new ObservableCollection<TaskModel>(_mapper.Map<IEnumerable<TaskModel>>(_uiOperator.GetTasksDAtaForUi()));
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
