using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogsTest
{
    public class ViewModel
    {
        private IDialogCoordinator dialogCoordinator;


        public ViewModel(IDialogCoordinator instance)
        {
            dialogCoordinator = instance;

            GetDialog();
        }

        public async void GetDialog()
        {
            var message = await dialogCoordinator.ShowProgressAsync(this, "Please", "载入中,请稍后...");
            message.SetIndeterminate();
            await Task.Delay(5000);

            await message.CloseAsync();
        }
    }
}
