import { createContext, useReducer, ReactElement } from 'react';
import {
	ProductState,
	IProductContext,
	ChildrenType,
} from '../interfaces/GlobalInterfaces';
import productReducer from '../reducers/productReducer';

const initialState: ProductState = {
	products: [],
	minPrice: 0,
	maxPrice: 0,
	sortBy: 'priceAsc',
	currentPage: 1,
	totalPages: 0,
};

export const ProductContext = createContext<IProductContext>({
	state: initialState,
	dispatch: () => {},
});

export const ProductProvider: React.FC<ChildrenType> = ({
	children,
}: ChildrenType): ReactElement => {
	const [state, dispatch] = useReducer(productReducer, initialState);

	return (
		<ProductContext.Provider value={{ state, dispatch }}>
			{children}
		</ProductContext.Provider>
	);
};
