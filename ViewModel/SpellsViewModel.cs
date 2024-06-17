using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MysticPartyTracker.Model;
using System.Collections.ObjectModel;


namespace MysticPartyTracker.ViewModel
{
    public partial class SpellsViewModel : ObservableObject
    {
        private readonly RestService _restService;
        public SpellsViewModel()
        {
            _restService = new RestService();
            FindSpellsAsyncCommand = new SpellCommand(); 
        }


        private ObservableCollection<Spells> _spells = new ObservableCollection<Spells>();
        public ObservableCollection<Spells> Spells
        {
           get { return _spells; }
           set { _spells = value; }
        }
        public ICommand FindSpellsAsyncCommand {  get; }

        public async Task<ObservableCollection<Spells>> SpellCommand()
        {
            Spells spells = new Spells(string Index, string, name);
            return await _restService.GetSpellsAsync();
        }
    }
}
