import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-UserName',
  template: `
  <div>
    <label for="firstName">First Name:</label>
    <input [(ngModel)]="firstName" name="firstName" />
  </div>
  <div>
    <label for="lastName">Last Name:</label>
    <input [(ngModel)]="lastName" name="lastName" />
  </div>
  <button (click)="createUserName()">Generate</button>
  <div *ngIf="fullUserName">Generated Username: {{ fullUserName }}</div>
`,
  styles: []
})
export class UserNameComponent implements OnInit {

  firstName: string;
  lastName:string;
  fullUserName: string;

  constructor() {
    this.firstName = "zero";
    this.lastName = "nothin";
    this.fullUserName = 'No Data'
   }

  ngOnInit() {
  }

  createUserName(){
    console.log("Done");
    const randomInt = Math.floor(Math.random() * 9 ) + 1;
    const firstNameFormatted = this.firstName.toLowerCase();
    const lastNameFormatted = this.lastName.toLowerCase();
    this.fullUserName = `${firstNameFormatted}_${lastNameFormatted}_${randomInt}`
  }

}
