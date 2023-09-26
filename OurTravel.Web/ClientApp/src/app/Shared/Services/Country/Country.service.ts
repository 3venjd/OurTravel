import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Country } from '../../Models/Country';
import { NgForm } from '@angular/forms';

@Injectable()
export class CountryService {

    url:string = environment.apiBaseUrl + 'countries';
    countryList: Country[] = [];
    EditCountryData: Country = new Country();
    constructor(private http: HttpClient) { }

    refreshList(){
        console.log("start");
        this.http.get(this.url)
        .subscribe({
            next : res => {
                this.countryList = res as Country[];
                console.log(res);
            },
            error: err => {console.log(err)}
        })
    }

    postCountry(){
        return this.http.post(this.url, this.EditCountryData)
    }

    resetForm(form:NgForm){
        form.form.reset();
        this.EditCountryData = new Country();
    }
}
