import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError, Subject, BehaviorSubject } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { Vehicle } from './models/vehicle';
import { Choices } from './models/choices';


@Injectable({
  providedIn: 'root'
})
export class SearchService {

  choice: Choices = { 
    sunroof: null, 
    fourWheelDrive: null, 
    lowMiles: null, 
    powerWindows: null, 
    navigation: null, 
    heatedSeats: null 
  };

  displayedColumns: string[] = ['make', 'year', 'color', 'price'];

  constructor(private _http: HttpClient) { }

  search() {
    var query : string = JSON.stringify(this.choice);
    const url = `https://localhost:5001/api/vehicleDescriptions/${query}`;
    return this._http.get<Vehicle[]>(url, {withCredentials: false});
  }
}
