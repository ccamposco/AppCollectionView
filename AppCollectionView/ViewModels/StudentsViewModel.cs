using AppCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCollectionView.ViewModels
{
    public class StudentsViewModel
    {
        public ObservableCollection<Students> students { get; set; }

        public StudentsViewModel()
        {
            students = new ObservableCollection<Students>
            {
                new Students{Name="María", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="José", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Carlos", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Mario", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Roberto", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Gloria", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Rosario", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Liliana", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Guisela", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Yessica", LastName="Rojas", Telephone = "(01) 980930897"},
                new Students{Name="Luis", LastName="Rojas", Telephone = "(01) 980930897"},


            };
        }
    }
}
