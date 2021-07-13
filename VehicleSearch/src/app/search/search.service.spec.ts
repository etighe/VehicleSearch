import { TestBed } from '@angular/core/testing';
import { HttpTestingController,  HttpClientTestingModule } from '@angular/common/http/testing';

import { SearchService } from './search.service';
import { HttpClient } from '@angular/common/http';

describe('SearchService', () => {
  let service: SearchService;
  let httpMock : HttpTestingController;
  let httpClient : HttpClient;

  beforeEach( () => {
      TestBed.configureTestingModule({
      providers: [SearchService],
      imports: [HttpClientTestingModule]
    });
    service = TestBed.inject(SearchService);
    httpMock = TestBed.get(HttpTestingController);
    httpClient = TestBed.inject(HttpClient);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
