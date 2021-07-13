import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Vehicle } from '../models/vehicle';
import { SearchService } from '../search.service';
import { HttpTestingController,  HttpClientTestingModule } from '@angular/common/http/testing';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.scss']
})
export class SearchResultsComponent implements OnInit {

  displayedColumns: string[] = ['make', 'year', 'color', 'price'];

  vehicles: Vehicle[] = [];

  isLoading = false;
  serverError = false;

  constructor(private _httpClient : HttpClient, private searchService : SearchService) { }

  ngOnInit(): void {
  }

  searchVehicles() {
    this.serverError = false;
    this.isLoading = true;
    this.searchService.search().subscribe(
        (data) => {
        this.displayedColumns = this.searchService.displayedColumns;
        this.vehicles = data;
        this.isLoading = false;
        },
        (error) => { 
          this.isLoading = false;
          this.serverError = true;
          console.log(`We got error from API : [${JSON.stringify(error)}])`)},
    )
  
}

}
