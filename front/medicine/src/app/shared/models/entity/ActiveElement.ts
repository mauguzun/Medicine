import { User } from "./User";
import { TranslatedActiveElement } from "./translate/TranslatedActiveElement";
import { Drug } from "./Drug";


export class ActiveElement {
  drugId!: number;
  drug!: Drug;
  quantity!: number;
  translations: TranslatedActiveElement[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
