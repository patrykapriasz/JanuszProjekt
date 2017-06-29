import { TestBed, inject } from '@angular/core/testing';

import { DataColumnsService } from './data-columns.service';

describe('DataColumnsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DataColumnsService]
    });
  });

  it('should be created', inject([DataColumnsService], (service: DataColumnsService) => {
    expect(service).toBeTruthy();
  }));
});
