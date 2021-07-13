import { Component, OnInit } from '@angular/core';
import { Choices } from '../models/choices';
import { SearchService } from '../search.service';
import { MatRadioChange } from '@angular/material/radio';

@Component({
  selector: 'app-pick-search-criteria',
  templateUrl: './pick-search-criteria.component.html',
  styleUrls: ['./pick-search-criteria.component.scss']
})
export class PickSearchCriteriaComponent implements OnInit {

  choice: Choices = { 
    sunroof: null, 
    fourWheelDrive: null, 
    lowMiles: null, 
    powerWindows: null, 
    navigation: null, 
    heatedSeats: null 
  };

  sunRoofSelection = undefined;
  fwdSelection = undefined;
  lowMilesSelection = undefined;
  powerWindowsSelection = undefined;
  navigationSelection = undefined;
  heatedSeatsSelection = undefined;




  changeSunroof(event: MatRadioChange) {
    this.searchService.displayedColumns = this.searchService.displayedColumns.filter( f => f !== 'hasSunroof');
    this.searchService.displayedColumns.push('hasSunroof');
    this.choice = { ...this.choice, sunroof: primative(event.value)};
    this.searchService.choice = this.choice;
  }

  changeFourWheelDrive(event: MatRadioChange) {
    this.searchService.displayedColumns = this.searchService.displayedColumns.filter( f => f !== 'isFourWheelDrive');
    this.searchService.displayedColumns.push('isFourWheelDrive');
    this.choice = { ...this.choice, fourWheelDrive: primative(event.value) };
    this.searchService.choice = this.choice;
  }

  changeLowMiles(event: MatRadioChange) {
    this.searchService.displayedColumns = this.searchService.displayedColumns.filter( f => f !== 'hasLowMiles');
    this.searchService.displayedColumns.push('hasLowMiles');
    this.choice = { ...this.choice, lowMiles: primative(event.value) };
    this.searchService.choice = this.choice;
  }

  changePowerWindows(event: MatRadioChange) {
    this.searchService.displayedColumns = this.searchService.displayedColumns.filter( f => f !== 'hasPowerWindows');
    this.searchService.displayedColumns.push('hasPowerWindows');
    this.choice = { ...this.choice, powerWindows: primative(event.value) };
    this.searchService.choice = this.choice;
  }

  changeNavigation(event: MatRadioChange) {
    this.searchService.displayedColumns = this.searchService.displayedColumns.filter( f => f !== 'hasNavigation');
    this.searchService.displayedColumns.push('hasNavigation');
    this.choice = { ...this.choice, navigation: primative(event.value) };
    this.searchService.choice = this.choice;
  }

  changeHeatedSeats(event: MatRadioChange) {
    this.searchService.displayedColumns = this.searchService.displayedColumns.filter( f => f !== 'hasHeatedSeats');
    this.searchService.displayedColumns.push('hasHeatedSeats');
    this.choice = { ...this.choice, heatedSeats: primative(event.value) };
    this.searchService.choice = this.choice;
  }

  constructor(private searchService: SearchService) { }

  ngOnInit(): void {
  }

  resetSelection() {

    this.sunRoofSelection = undefined;
    this.fwdSelection = undefined;
    this.lowMilesSelection = undefined;
    this.powerWindowsSelection = undefined;
    this.navigationSelection = undefined;
    this.heatedSeatsSelection = undefined;

    this.searchService.displayedColumns = ['make', 'year', 'color', 'price'];

    this.searchService.choice = { 
      sunroof: null, 
      fourWheelDrive: null, 
      lowMiles: null, 
      powerWindows: null, 
      navigation: null, 
      heatedSeats: null 
    };

  }

}

function primative(value: any): boolean | null {
  if (value === "null") { return null }
  else { return value === "true" ? true : false }
}

