import { FeatureService } from './../../services/feature.service';
import { Feature } from './../../models/feature';
import { ModelService } from './../../services/model.service';
import { Make } from './../../models/make';
import { MakeService } from '../../services/make.service';
import { Component, OnInit } from '@angular/core';
import { Model } from 'src/app/models/model';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.scss']
})
export class VehicleFormComponent implements OnInit {
  makes: Make[];
  models: Model[];
  features: Feature[];
  selectedMakeId: number;

  constructor(
    private makeService: MakeService,
    private modelService: ModelService,
    private featureService: FeatureService
  ) {}

  ngOnInit() {
    this.makeService.getMakes().subscribe(makes => (this.makes = makes));
    this.featureService
      .getFeatures()
      .subscribe(features => (this.features = features));
  }

  onMakeChange() {
    if (this.selectedMakeId) {
      this.modelService
        .getModels(this.selectedMakeId)
        .subscribe(models => (this.models = models ? models : []));
    } else {
      this.models = [];
    }
  }
}
