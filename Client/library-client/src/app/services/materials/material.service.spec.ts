import { TestBed } from '@angular/core/testing';

import { MaterialService } from './material.service';

describe('MaterialsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MaterialService = TestBed.get(MaterialService);
    expect(service).toBeTruthy();
  });
});
