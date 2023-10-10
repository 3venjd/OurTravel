import { City } from "./City";

export class State {
    id: number = 0;
    name: string = '';
    flag : string = '';
    cities : City[] = [];
    description : string = '';
    quantityCities : number = 0;
}
