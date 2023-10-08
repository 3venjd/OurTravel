import { State } from "./State";

export class Country {
    id: number = 0;
    name: string = '';
    flag: string = '';
    description : string = '';
    states: State[] = [];
    quantityStates: number = 0;
    capital: string = '';
    
}
