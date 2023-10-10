import { state } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { State } from 'src/app/Shared/Models/State';
import { RepositoryService } from 'src/app/Shared/Services/Repository.service';

@Component({
  selector: 'app-State',
  templateUrl: './State.component.html',
  styleUrls: ['./State.component.css']
})
export class StateComponent implements OnInit {

  stateId: string = '';
  stateData : State = new State;

  constructor(private activateRoute : ActivatedRoute, public service: RepositoryService<State>) { }

  ngOnInit() {
    this.stateId = this.activateRoute.snapshot.paramMap.get('id')!;
    this.service.GetDataDetails('states', this.stateId)
      .subscribe({
        next: resp => {
          this.stateData = resp as State
          console.log(this.stateData);
        },
        error: err => {console.log(err)}
      });
  }

}
