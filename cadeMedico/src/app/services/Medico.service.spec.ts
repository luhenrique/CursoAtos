/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { MedicoService } from './Medico.service';

describe('Service: Medico', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MedicoService]
    });
  });

  it('should ...', inject([MedicoService], (service: MedicoService) => {
    expect(service).toBeTruthy();
  }));
});
