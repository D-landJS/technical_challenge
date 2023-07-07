import './Paragraph.css';

const Paragraph = ({ children, color = '', variant = '' }: any) => {
	let classNames = 'paragraph';

	if (color) {
		classNames += ` ${color}`;
	}

	if (variant) {
		classNames += ` ${variant}`;
	}

	return <p className={classNames}>{children}</p>;
};

export default Paragraph;
