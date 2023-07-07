import { ProductProvider } from './context/productContext';
import ProductPage from './components/templates/pages/ProductPage';

function App() {
	return (
		<div className="container">
			<ProductProvider>
				<ProductPage />
			</ProductProvider>
		</div>
	);
}

export default App;
