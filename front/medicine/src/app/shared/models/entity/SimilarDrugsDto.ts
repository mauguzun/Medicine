import { DrugDto } from "./DrugDto";


export class SimilarDrugsDto {
  similarDrugsList: DrugDto[] = [];
  id!: number;
  createdAt?: Date;
}
