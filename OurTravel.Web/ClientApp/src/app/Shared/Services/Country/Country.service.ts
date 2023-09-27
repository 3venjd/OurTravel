import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Country } from '../../Models/Country';
import { NgForm } from '@angular/forms';

@Injectable()
export class CountryService <T> {

    url:string = environment.apiBaseUrl;
    countryList: Country[] = [];
    EditCountryData: Country = new Country();
    constructor(private http: HttpClient) { }
    listData : T[] = [];
    EditData? : T;

    refreshList(module :string){
        this.http.get(this.url + module)
        .subscribe({
            next : res => {
                this.listData = res as T[];
                console.log(this.listData);
            },
            error: err => {console.log(err)}
        })
    }

    postCountry(module :string){
        return this.http.post(this.url + module, this.EditCountryData)
    }

    resetForm(form:NgForm, model : T){
        form.form.reset();
        this.EditData = model;
    }
}
