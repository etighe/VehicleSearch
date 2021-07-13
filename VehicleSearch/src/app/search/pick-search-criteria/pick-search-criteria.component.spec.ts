import { ComponentFixture, TestBed } from '@angular/core/testing';
import { PickSearchCriteriaComponent } from './pick-search-criteria.component';
import { HttpTestingController,  HttpClientTestingModule } from '@angular/common/http/testing';
import { HttpClient } from '@angular/common/http';

describe('PickSearchCriteriaComponent', () => {
  let component: PickSearchCriteriaComponent;
  let fixture: ComponentFixture<PickSearchCriteriaComponent>;
  let httpMock : HttpTestingController;
  let httpClient : HttpClient;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PickSearchCriteriaComponent ],
      imports: [HttpClientTestingModule]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PickSearchCriteriaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
