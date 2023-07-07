import './Typography.css';

const Typography = ({ variant, color, children }: any) => {
	const classNames = `typography ${variant} ${color}`;

	return <div className={classNames}>{children}</div>;
};

export default Typography;
