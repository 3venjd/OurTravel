import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Country } from 'src/app/Shared/Models/Country';
import { RepositoryService } from 'src/app/Shared/Services/Repository.service';

@Component({
  selector: 'app-Country',
  templateUrl: './Country.component.html',
  styleUrls: ['./Country.component.css']
})
export class CountryComponent implements OnInit {

  OnSubmit(form: NgForm) {
    this.service.formSubmitted = true;
    if(form.valid) {
      if (this.service.EditData.id == 0) {
        this.InsertRecord(form);
      }
      else{
        this.UpdateRecord(form);
      }
    }
  }

  constructor(public service: RepositoryService<Country>,
              private toastr: ToastrService) {

  }

  ngOnInit() {
    this.service.refreshList('countries');
  }

  populate(selectedRecord: Country){
    this.service.EditData = Object.assign({}, selectedRecord);
    console.log(this.service.EditData.id)
  }

  InsertRecord(form: NgForm) {
    this.service.postData('countries',form.value)
    .subscribe({
      next: res => {
        this.service.refreshList('countries');
        this.service.resetForm(form, new Country);
        this.toastr.success('Saved', 'Country')
      },
      error: err => {console.error(err)}
    })
  }

  
  UpdateRecord(form: NgForm) {
    form.value.id = this.service.EditData.id;
    this.service.putData('countries',form.value)
    .subscribe({
      next: res => {
        this.service.refreshList('countries');
        this.service.resetForm(form, new Country);
        this.toastr.info('Updated', 'Country')
      },
      error: err => {console.error(err)}
    })
  }

  onDelete(id: number,form: NgForm) {
    if (confirm('Are you sure to delete this record?')) {
        this.service.deleteData('countries',id)
        .subscribe({
          next: res => {
            this.service.refreshList('countries');
            this.service.resetForm(form, new Country);
            this.toastr.error('Erased', 'Country')
          },
          error: err => {console.error(err)}
        })
    }
    
  }
}
