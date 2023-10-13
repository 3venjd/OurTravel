import { Places } from "./Places";

export class City {
  id: number = 0;
  name: string = '';
  description : string = '';
  flag: string = '';
  quantityPlaces: number = 0;
  places: Places[] = [];
}
