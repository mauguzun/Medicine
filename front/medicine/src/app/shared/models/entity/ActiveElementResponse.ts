import { User } from "./User";
import { DrugDto } from "./DrugDto";
import { TranslatedActiveElement } from "./translate/TranslatedActiveElement";


export class ActiveElementResponse {
  drug!: DrugDto;
  drugId!: number;
  quantity!: number;
  translations: TranslatedActiveElement[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
