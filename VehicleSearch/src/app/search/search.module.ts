import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SearchResultsComponent } from './search-results/search-results.component';
import { MatTableModule } from '@angular/material/table';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatRadioModule } from '@angular/material/radio';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { PickSearchCriteriaComponent } from './pick-search-criteria/pick-search-criteria.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    SearchResultsComponent,
    PickSearchCriteriaComponent
  ],
  imports: [
    CommonModule,
    MatProgressSpinnerModule,
    MatTableModule,
    MatCheckboxModule,
    MatRadioModule,
    BrowserModule,
    FormsModule,
    HttpClientModule,
  ],
  exports: [
    SearchResultsComponent,
    PickSearchCriteriaComponent
  ]
})
export class SearchModule { }
