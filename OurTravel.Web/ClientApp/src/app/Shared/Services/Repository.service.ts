import { HttpClient } from '@angular/common/http';
import { Injectable, Input } from '@angular/core';
import { Country } from '../Models/Country';
import { environment } from 'src/environments/environment';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class RepositoryService <T> {

  constructor(private http:HttpClient) {
  }

  url:string = environment.apiBaseUrl;
      listData : T[] = [];
      formSubmitted: boolean = false;
      EditData: T = {} as T ;
      refreshList(module :string){
          this.http.get(this.url + module)
          .subscribe({
              next : res => {
                  this.listData = res as T[];
              },
              error: err => {console.log(err)}
          })
      }

      GetDataDetails(module : string, idData : string){
        return this.http.get(this.url + module + `/${idData}`);
      }

      postData(module :string,form:NgForm){
          return this.http.post(this.url + module, form)
      }

      putData(module :string,form:NgForm){
        return this.http.put(this.url + module, form)
      }

      deleteData(module:string,id:number){
        return this.http.delete(this.url + module + '/'+ id)
      }

      resetForm(form:NgForm, model : T){
          form.form.reset();
          this.EditData = model;
          this.formSubmitted = false;
      }

}
