import { DrugCategoryDto } from "./DrugCategoryDto";
import { SimilarDrugsDto } from "./SimilarDrugsDto";
import { ActiveElementResponse } from "./ActiveElementResponse";
import { TranslatedDrugsResponce } from "./translate/TranslatedDrugsResponce";
import { User } from "./User";

export class DrugDto {
  translations: TranslatedDrugsResponce[] = [];
  drugCategories: DrugCategoryDto[] = [];
  similarDrugsList: SimilarDrugsDto[] = [];
  activeElements: ActiveElementResponse[] = [];
  recomendation?: string;
  title?: string;
  oneUnitSizeInGramm!: number;
  similarDrugsId!: number;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
